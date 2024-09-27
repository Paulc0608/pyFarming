import tkinter as tk
import gui

windowMain = tk.Tk()



windowMain.geometry("700x700")
windowMain.title("Skyblock Farming Script")

label = tk.Label(windowMain, text="Farming Script")
label.pack()

buttonMelon = tk.Button(windowMain, text="Melonen", command=gui.threadOneStart)
buttonMelon.pack()
buttonWarts = tk.Button(windowMain, text="Nether Warts", command=gui.threadTwoStart)
buttonWarts.pack()
buttonStop = tk.Button(windowMain, text="Stop", command=gui.stop)
buttonStop.pack()
windowMain.mainloop()
