import pygetwindow as gw
import pyautogui
import win32gui
import win32con
import threading
import time

# Find the Minecraft windows by partial title match
window1 = gw.getWindowsWithTitle('SkyClient (Forge 1.8.9)')[0]  # First window
window2 = gw.getWindowsWithTitle('SkyClient (Forge 1.8.9)')[1]  # Second window

def activate_window(window):
    """ Bring the specified window to the foreground """
    hwnd = window._hWnd  # Get window handle
    win32gui.ShowWindow(hwnd, win32con.SW_RESTORE)  # Restore the window if minimized
    win32gui.SetForegroundWindow(hwnd)  # Set as foreground window

def send_inputs_to_window(window, inputs):
    """ Activate a window and send a sequence of inputs """
    activate_window(window)
    for key in inputs:
        pyautogui.press(key)
        time.sleep(0.1)  # Small delay between inputs to avoid missing keys

# Define the macro inputs for both windows
inputs_window1 = ['w', 'a', 'd', 'space']  # Inputs for the first Minecraft window
inputs_window2 = ['space', 'd', 'w', 'a']  # Inputs for the second Minecraft window

# Create threads to send inputs to both windows simultaneously
thread1 = threading.Thread(target=send_inputs_to_window, args=(window1, inputs_window1))
thread2 = threading.Thread(target=send_inputs_to_window, args=(window2, inputs_window2))

# Start both threads at the same time
thread1.start()
thread2.start()

# Wait for both threads to finish
thread1.join()
thread2.join()
