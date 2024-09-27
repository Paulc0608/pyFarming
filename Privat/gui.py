
import time
import pyautogui
import threading

stop_event = threading.Event()

running = True
def melon():

    while not stop_event.is_set():

        ###############
        ## Speed 400 ##
        ###############

        time.sleep(3)
        yaw()


        time.sleep(0.5)
        pyautogui.keyDown('d')
        #pyautogui.keyDown('w')
        pyautogui.keyDown('q')


        sleep(540)#340
        if stop_event.is_set():
            break

        pyautogui.keyUp('d')
        yaw()
        pyautogui.keyDown('a')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('a')
        yaw()
        pyautogui.keyDown('d')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('d')
        yaw()
        pyautogui.keyDown('a')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('a')
        yaw()
        pyautogui.keyDown('d')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('d')
        yaw()
        pyautogui.keyDown('a')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('a')
        yaw()
        pyautogui.keyDown('d')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('d')
        yaw()
        pyautogui.keyDown('a')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('a')
        yaw()
        pyautogui.keyDown('d')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('d')
        yaw()
        pyautogui.keyDown('a')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('a')
        yaw()
        pyautogui.keyDown('d')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('d')
        yaw()
        pyautogui.keyDown('a')
        pyautogui.keyDown('q')
        #pyautogui.keyDown('w')

        sleep(540)
        if stop_event.is_set():
            break

        pyautogui.keyUp('a')
        yaw()
        pyautogui.keyUp('w')
        pyautogui.keyDown('s')
        pyautogui.keyUp('q')

        sleep(40)
        if stop_event.is_set():
            break

        pyautogui.keyUp('s')


def warts():

    while not stop_event.is_set():

        ###############
        ## Speed 116 ##
        ###############

        time.sleep(3)
        # tp nach Oben
        pyautogui.press("t")
        pyautogui.write("/warp garden")
        pyautogui.press('enter')
        pyautogui.keyDown('shift')

        sleep(10)
        if stop_event.is_set():
            break

        pyautogui.keyUp('shift')

        sleep(30)
        if stop_event.is_set():
            break

        #Reihe 1 /// Start Links
        pyautogui.keyDown('d')
        pyautogui.keyDown('q')

        sleep(960)
        if stop_event.is_set():
            break

        pyautogui.keyUp('d')
        pyautogui.keyUp('q')

        #Reihe 2 /// Start Rechts
        pyautogui.keyDown('a')
        pyautogui.keyDown('q')

        sleep(960)
        if stop_event.is_set():
            break


        pyautogui.keyUp('a')
        pyautogui.keyUp('q')

        # Reihe 3 /// Start Links
        pyautogui.keyDown('d')
        pyautogui.keyDown('q')

        sleep(960)
        if stop_event.is_set():
            break


        pyautogui.keyUp('d')
        pyautogui.keyUp('q')


# Threads initialisieren
thread1 = threading.Thread(target=melon)
thread2 = threading.Thread(target=warts)

def threadOneStart():
    global thread1
    if not thread1.is_alive():
        thread1 = threading.Thread(target=melon)
        stop_event.clear()  # Event zurücksetzen
        thread1.start()

def threadTwoStart():
    global thread2
    if not thread2.is_alive():
        thread2 = threading.Thread(target=warts)
        stop_event.clear()  # Event zurücksetzen
        thread2.start()

def stop():
    stop_event.set()  # Event setzen, um die Threads sofort zu stoppen
    if thread1.is_alive():
        thread1.join()  # Warten, bis thread1 beendet ist
    if thread2.is_alive():
        thread2.join()  # Warten, bis thread2 beendet istd

def sleep(timer):
    for _ in range(timer):
        if stop_event.is_set():
            break
        time.sleep(0.1)


def yaw():
    # Set Yaw and Pitch
    pyautogui.keyUp("w")
    pyautogui.keyUp("q")
    pyautogui.press("t")
    pyautogui.write("/setYaw 0 -58")
    pyautogui.press('enter')