from pymavlink import mavutil
import time
import sys
address = "udpin:0.0.0.0:14550"
#address = "/dev/ttyUSB0"
#address = "/dev/ttyACM1"

#vehicle.wait_heartbeat()
#print("baglanti basarili")
def ihaMove(vehicle):
    def get_gps():
        message = vehicle.recv_match(type='GLOBAL_POSITION_INT', blocking=True)
        lat = message.lat / 1e7
        lon = message.lon / 1e7
        #print(f"Anlık GPS: Enlem lat {lat}, Boylam lon {lon}")
        return lat, lon


    def get_alt():
        message = vehicle.recv_match(type='GLOBAL_POSITION_INT',blocking=True)
        alt = message.relative_alt
        alt = alt/1000
        return alt

    def takeoff(alt):
        vehicle.mav.command_long_send(vehicle.target_system, vehicle.target_component, mavutil.mavlink.MAV_CMD_NAV_TAKEOFF, 0, 0, 0, 0, 0, 0, 0, 10)
        while True:
            current_alt = get_alt()
            current_lat, current_lon = get_gps()
            if current_alt < alt:
                pass
                #print(f"Anlık irtifa: {current_alt}")
                #print(f"Anlık GPS: Enlem {current_lat}, Boylam {current_lon}")
            elif current_alt >= alt:
                pass
                #print("İstenilen irtifaya ulaşıldı")
                break
    #def takeoff(alt):
        #vehicle.mav.command_long_send(vehicle.target_system, vehicle.target_component, mavutil.mavlink.MAV_CMD_NAV_TAKEOFF,0,0,0,0,0,0,0,alt)
        #while True:
            #current_alt = get_alt()
            #if current_alt < alt:
                #print(f"Anlik irtifa{current_alt}")
            #elif current_alt >= alt:
                #print("İstenilen irtifaya ulasildi")
                #break

    vehicle.set_mode("GUIDED")
    vehicle.arducopter_arm()
    #vehicle.motors_armed_wait()
    #print("arac arm edildi")


    def move(gps, z):
        lat, lon = gps
        vehicle.mav.send(mavutil.mavlink.MAVLink_set_position_target_local_ned_message(
            10, vehicle.target_system, vehicle.target_component, 9,
            int(0b0000011111111000),
            lat, lon, z,
            0, 0, 0,
            0, 0, 0,
            0, 0
        ))

    def go_to(get_gps,alt):
        vehicle.mav.mission_item_send(0,0,0,
                                  mavutil.mavlink.MAV_FRAME_GLOBAL_RELATIVE_ALT,
                                  mavutil.mavlink.MAV_CMD_NAV_WAYPOINT,
                                  2,0,0,0,0,0,get_gps,alt)

    takeoff(10)
    time.sleep(10)

    current_gps = get_gps()
    move(current_gps, 0)
    time.sleep(5)

    move(current_gps, 3)
    time.sleep(5)

    move(current_gps, 5)
    time.sleep(5)

    vehicle.set_mode("RTL")

