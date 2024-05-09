import math

from pymavlink import mavutil

yardim_port = "COM8"
imha_port = "COM9"

simulasyon = 'udpin:0.0.0.0:14550'  # simulation
# address = "/dev/ttyACM0"
# address = "/dev/ttyTHS1:115200"
# address = "COM8"  # port
# port_name =  False #os.getcwd()[0]
# baud_rate =  False #os.getcwd()[1]
# hedefe_git = False #os.getcwd()[2]
# dur =        False #os.getcwd()[3]
# eve_don =    False #os.getcwd()[4]
# inis_yap =   False #os.getcwd()[5]
# hedef_lat =  False #os.getcwd()[6]
# hedef_lon =  False #os.getcwd()[7]
iha = mavutil.mavlink_connection(simulasyon, baud=115200, autoreconnect=True)
iha.wait_heartbeat()

def iha_sec(port):
    global iha
    try:
        if (port == "0"):
            iha = mavutil.mavlink_connection(imha_port, baud=115200, autoreconnect=True)
        elif (port == "1"):
            iha = mavutil.mavlink_connection(yardim_port, baud=115200, autoreconnect=True)
        elif (port == "2"):
            iha = mavutil.mavlink_connection(simulasyon, baud=115200, autoreconnect=True)
        iha.wait_heartbeat()
        return "ihaya bağlanıldı"
    except:
        return "ihaya bağlanılamadı"


counter = 0
code_working = True


def get_iha():
    return iha


def return_iha():
    iha.set_mode("RTL")

def mode_manuel(vehicle):
    vehicle.mav.send(vehicle.mav.command_long_encode(
    0, 0,  # target_system, target_component
    mavutil.mavlink.MAV_CMD_DO_SET_MODE,  # command
    0,  # confirmation
    217,  # param 1, base mode
    1,  # param 2, main mode
    0,  # param 3, sub mode
    0, 0, 0, 0  # param 4, 5, 6, 7 not used
))

def messages():
    try:
        global_position_int = iha.recv_match(type='GLOBAL_POSITION_INT', blocking=True).to_dict()
        attitude = iha.recv_match(type='ATTITUDE', blocking=True).to_dict()
        sys_status = iha.recv_match(type='SYS_STATUS', blocking=True).to_dict()
        scaled_pressure = iha.recv_match(type='SCALED_PRESSURE', blocking=True).to_dict()
        sfr_hud = iha.recv_match(type='VFR_HUD', blocking=True).to_dict()
        #nav_controller_output = iha.recv_match(type="NAV_CONTROLLER_OUTPUT", blocking=True).to_dict()
        terrain_report = iha.recv_match(type="TERRAIN_REPORT", blocking=True).to_dict()
        raw_imu = iha.recv_match(type="RAW_IMU", blocking=True).to_dict()
        gps_raw_int = iha.recv_match(type="GPS_RAW_INT", blocking=True).to_dict()
        # roll = round(nav_controller_output['nav_roll'], 10)
        # pitch = round(nav_controller_output['nav_pitch'], 10)
        new_message = (
            f"{global_position_int['alt'] / 1e7} : {global_position_int['lat'] / 1e7} : {global_position_int['lon'] / 1e7} : "
            f"{round(terrain_report['current_height'], 2)} : "
            f"{round(scaled_pressure['press_abs'], 2)} : {scaled_pressure['temperature'] / 100} : "
            f"{sys_status['voltage_battery'] / 1000} : {attitude['pitch'] * 180 / math.pi} : "
            f"{attitude['roll'] * 180 / math.pi} : {sfr_hud['heading']} : {terrain_report['current_height'] / 0.3048} : "
            f"{attitude['rollspeed'] * 180 / math.pi} : {raw_imu['ygyro']} : {gps_raw_int['satellites_visible']}")
        #
        #
        #
        # if dur == "True":
        #     iha.mav.command_long_send(
        #         iha.target_system,  # target_system
        #         iha.target_component,  # target_component
        #         mavutil.mavlink.MAV_CMD_DO_HOLD,  # command
        #         0,  # confirmation
        #         1,  # param1 (hold enabled)
        #         0,  # param2 (not used)
        #         0,  # param3 (not used)
        #         0,  # param4 (not used)
        #         0,  # param5 (not used)
        #         0,  # param6 (not used)
        #         0  # param7 (not used)
        #     )
        # if inis_yap == "True":
        #     iha.mav.command_long_send(
        #         iha.target_system,
        #         iha.target_component,
        #         mavutil.mavlink.MAV_CMD_DO_SET_MODE,
        #         0,
        #         1,  # base_mode (MANUAL + STABILIZE + GUIDED + AUTO)
        #         5,  # custom_mode (Loiter)
        #         0, 0, 0, 0, 0
        #     )
        #     print("iha iniş yap a basildi")
        return new_message
    except():
        return "61"
