import sys
import uselect
import machine
import time

led = machine.Pin(2, machine.Pin.OUT)

led.value(1)
time.sleep(1)
led.value(0)

serialPoll = uselect.poll()
serialPoll.register(sys.stdin, uselect.POLLIN)

def handle_command(command):
    if command is None:  # filter out empty messages
        return
    print("Command received:", command)
    if command == "a":
        led.value(1)
        time.sleep(1)
        led.value(0)
        time.sleep(1)
        sys.stdout.buffer.write(b"test a\n")
    if command == "b":
        led.value(1)
        time.sleep(1)
        led.value(0)
        time.sleep(1)
        led.value(1)
        time.sleep(1)
        led.value(0)
        time.sleep(1)
        sys.stdout.buffer.write(b"test a\n")
    else:  # unrecognized command
        sys.stdout.buffer.write(b"error\n")

def readSerial():
    return sys.stdin.read(1) if serialPoll.poll(0) else None

while True:
    message = readSerial()
    handle_command(message)

