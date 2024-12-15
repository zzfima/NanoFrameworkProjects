import serial
import tkinter as tk

# Configure the serial port (adjust 'COM7' to your actual COM port)
ser = serial.Serial('COM7', 115200, timeout=1)

def send_command():
    ser.write(b'p\n')

# Create the GUI
root = tk.Tk()
root.title("ESP32 Command Sender")

button = tk.Button(root, text="Send 'p'", command=send_command)
button.pack(pady=20)

root.mainloop()