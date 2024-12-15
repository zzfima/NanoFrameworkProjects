import serial
import tkinter as tk

# Configure the serial port (adjust 'COM7' to your actual COM port)
ser = serial.Serial('COM7', 115200, timeout=1)

def send_command_a():
    ser.write(b'a\n')

def send_command_b():
    ser.write(b'b\n')

# Create the GUI
root = tk.Tk()
root.title("ESP32 Command Sender")

button_a = tk.Button(root, text="Send 'a'", command=send_command_a)
button_a.pack(pady=20)

button_b = tk.Button(root, text="Send 'b'", command=send_command_b)
button_b.pack(pady=20)

root.mainloop()