import sys
import uselect
import machine
import time

# config led
led = machine.Pin(2, machine.Pin.OUT)

# config relays
relay = machine.Pin(26, machine.Pin.OUT)

#config serial port
serialPoll = uselect.poll()
serialPoll.register(sys.stdin, uselect.POLLIN)

#startup blink
led.value(1)
time.sleep(1)
led.value(0)

#main endless loop
while True:
    command = readSerial()
    handle_command(command)

def readSerial():
    return sys.stdin.read(1) if serialPoll.poll(0) else None

def handle_command(command):
    if command is None:  # filter out empty messages
        return
    #print("Command received:", command)
    if command == "a":
        relay.value(0)
    if command == "b":
        relay.value(1)
    if command == "c":
        led.value(1)
        time.sleep(0.5)
        led.value(0)
        time.sleep(0.5)
        led.value(1)
        time.sleep(0.5)
        led.value(0)
        time.sleep(0.5)
        led.value(1)
        time.sleep(0.5)
        led.value(0)
        time.sleep(0.5)
        #sys.stdout.buffer.write(b"test c\n")
    else:  # unrecognized command
        #sys.stdout.buffer.write(b"error\n")