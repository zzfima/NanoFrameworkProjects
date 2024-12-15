import sys
import uselect
import machine
import time

led = machine.Pin(2, machine.Pin.OUT)

serialPoll = uselect.poll()
serialPoll.register(sys.stdin, uselect.POLLIN)

def handle_command(command):
    if command is None:  # filter out empty messages
        led.value(1)
        time.sleep(0.2)
        led.value(0)
        time.sleep(0.2)
        return
    print("Command received:", command)
    if command == "p":
        led.value(1)
        time.sleep(2)
        led.value(0)
        time.sleep(2)
        sys.stdout.buffer.write(b"test\n")
    else:  # unrecognized command
        led.value(1)
        time.sleep(1)
        led.value(0)
        time.sleep(1)
        sys.stdout.buffer.write(b"error\n")

def readSerial():
    return sys.stdin.read(1) if serialPoll.poll(0) else None

while True:
    message = readSerial()
    handle_command(message)
