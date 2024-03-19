import math

from pymavlink import mavutil
import sys

# address = "udpin:localhost:14551"
address = 'udpin:0.0.0.0:14550'  # simulation
# address = "/dev/ttyACM0"
# address = "/dev/ttyTHS1:115200"
# address = "COM8"  # port

port_name = sys.argv[1]
baud_rate = sys.argv[2]
hedefe_git = sys.argv[3]
dur = sys.argv[4]
eve_don = sys.argv[5]
inis_yap = sys.argv[6]
hedef_lat = sys.argv[7]
hedef_lon = sys.argv[8]



def takeoff(alt):
    iha.mav.command_long_send(iha.target_system, iha.target_component,
                                         mavutil.mavlink.MAV_CMD_NAV_TAKEOFF, 0, 0,0, 0, 0, 0, 0, alt)

def move(y, x, z):
    iha.mav.send(mavutil.mavlink.MAVLink_set_position_target_local_ned_message(
        10, iha.target_system, iha.target_component, 9, int(0b0000011111111000), y, x, z, 0, 0, 0, 0, 0, 0, 0,
        0))

iha = mavutil.mavlink_connection(port_name, baud=baud_rate, autoreconnect=True)
iha.wait_heartbeat()
posx = 20
posy = 20
posz = -20

counter = 0

try:

    global_position_int = iha.recv_match(type='GLOBAL_POSITION_INT', blocking=True).to_dict()
    attitude = iha.recv_match(type='ATTITUDE', blocking=True).to_dict()
    sys_status = iha.recv_match(type='SYS_STATUS', blocking=True).to_dict()
    scaled_pressure = iha.recv_match(type='SCALED_PRESSURE', blocking=True).to_dict()
    sfr_hud = iha.recv_match(type='VFR_HUD', blocking=True).to_dict()
    nav_controller_output = iha.recv_match(type="NAV_CONTROLLER_OUTPUT", blocking=True).to_dict()
    terrain_report = iha.recv_match(type="TERRAIN_REPORT", blocking=True).to_dict()

    # roll = round(nav_controller_output['nav_roll'], 10)
    # pitch = round(nav_controller_output['nav_pitch'], 10)
    new_message = (f"{global_position_int['alt']} : {global_position_int['lat']} : {global_position_int['lon']} : "
                   f"{round(terrain_report['current_height'], 2)} : "
                   f"{round(scaled_pressure['press_abs'], 2)} : {scaled_pressure['temperature'] / 100} : "
                   f"{sys_status['voltage_battery']/1000} : {attitude['pitch'] * 180 / math.pi} : "
                   f"{attitude['roll'] * 180 / math.pi} : {sfr_hud['heading']} : {terrain_report['current_height'] / 0.3048} : "
                   f"{attitude['rollspeed'] * 180 / math.pi} : ")
    print(new_message)
    if eve_don == "True":
        iha.set_mode("RTL")
        print("iha eve döne basıldı")

    if dur == "True":
        iha.mav.command_long_send(
            iha.target_system,  # hedef sistem
            iha.target_component,  # hedef bileşen
            mavutil.mavlink.MAV_CMD_OVERRIDE_GOTO,  # komut
            0,  # confirmation
            mavutil.mavlink.MAV_GOTO_DO_HOLD,  # param1
            0,  # param2
            0,  # param3
            0,  # param4
            0,  # param5
            0,  # param6
            0  # param7
        )

    if inis_yap == "True":
        iha.mav.command_long_send(
            iha.target_system,
            iha.target_component,
            mavutil.mavlink.MAV_CMD_DO_SET_MODE,
            0,
            1,  # base_mode (MANUAL + STABILIZE + GUIDED + AUTO)
            5,  # custom_mode (Loiter)
            0, 0, 0, 0, 0
        )
        print("iha iniş yap a basıldı")

    if hedefe_git == "True":
        if not iha.motors_armed():
            iha.set_mode('GUIDED')
            iha.arducopter_arm()
            iha.motors_armed_wait()
            takeoff(10)
        iha.mav.mission_item_send(0, 0, 0, mavutil.mavlink.MAV_FRAME_GLOBAL_RELATIVE_ALT,
                                  mavutil.mavlink.MAV_CMD_NAV_WAYPOINT, 2, 0, 0, 0, 0, 0, hedef_lat, hedef_lon, 10)

        print("iha hedefe git basıldı")

except:
    print("yardim iha veriler gelmedi")

