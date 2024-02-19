import tkinter as tk
from tkinter import messagebox

class Morphapp:
    def __init__(self, master):
        self.master = master
        self.master.title("Morphapp")
        self.master.geometry("400x200")
        self.master.configure(bg="navy")
        
        self.label1 = tk.Label(self.master, text="Welcome to MorphApp. Select your image using the following support apps:", bg="navy", fg="white")
        self.label1.pack()

        self.choice_var = tk.StringVar()
        self.choice_var.set("Google Photos")

        self.choices = [
            "Google Photos",
            "Windows Image Browser",
            "Google Images repository"
        ]

        self.choice_box = tk.OptionMenu(self.master, self.choice_var, *self.choices)
        self.choice_box.pack()

        self.transform_button = tk.Button(self.master, text="TRANSFORM", bg="blue", fg="white", command=self.transform)
        self.transform_button.pack()

    def transform(self):
        selected_option = self.choice_var.get()
        messagebox.showinfo("Transformation", f"Transformation initiated using {selected_option}. Please use Universal Transformation Glove for the process.")

def main():
    root = tk.Tk()
    app = Morphapp(root)
    root.mainloop()

if __name__ == "__main__":
    main()
