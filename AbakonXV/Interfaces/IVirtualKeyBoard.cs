﻿namespace AbakonXVWPF.Interfaces
{
    public interface IVirtualKeyboardInjectable
    {
        /// <summary>
        /// This would be the TextBox or similar control that you want to use the Virtual Keyboard to type characters into.
        /// It is how you inform the Virtual Keyboard where to put the characters you type with it.
        /// </summary>
        System.Windows.Controls.Control ControlToInjectInto { get; }

        /// <summary>
        /// Get or set the application-window's reference to the virtual-keyboard.
        /// </summary>
        KeyBoardWindow TheVirtualKeyboard { get; set; }
    }
}
