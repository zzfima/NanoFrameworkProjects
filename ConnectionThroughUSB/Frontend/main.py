import serial
import tkinter as tk

# Create the GUI
root = tk.Tk()
root.title("ESP32 Command Sender")

portName = tk.StringVar()
ser = None


def send_command_set_port():
    global ser
    ser = serial.Serial(portName.get(), 115200, timeout=1)
    button_a.config(state=tk.NORMAL)
    button_b.config(state=tk.NORMAL)
    button_c.config(state=tk.NORMAL)


def send_command_a():
    if ser:
        ser.write(b"a\n")


def send_command_b():
    if ser:
        ser.write(b"b\n")


def send_command_c():
    if ser:
        ser.write(b"c\n")


lbl_port = tk.Label(root, text="Edit port name for init:")
lbl_port.pack(pady=5)
name_entry = tk.Entry(root, textvariable=portName, font=("calibre", 10, "normal"))
name_entry.insert(0, "COM0")
name_entry.pack(pady=5)
button_port = tk.Button(root, text="set port", command=send_command_set_port)
button_port.pack(pady=5)

button_a = tk.Button(
    root, text="blink one time", command=send_command_a, state=tk.DISABLED
)
button_a.pack(pady=20)

button_b = tk.Button(
    root, text="blink two times", command=send_command_b, state=tk.DISABLED
)
button_b.pack(pady=20)

button_c = tk.Button(
    root, text="blink three times", command=send_command_c, state=tk.DISABLED
)
button_c.pack(pady=20)

root.mainloop()
