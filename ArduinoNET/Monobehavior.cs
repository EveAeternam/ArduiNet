using System;
using System.Collections.Generic;
using System.Text;
using ArduiNET;

namespace ArduiNET
{
    public class Monobehavior : Monoduino
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Digital I/O Control
        /// </summary>
        public class Digital
        {
            /// <summary>
            /// Reads the value from a specified digital pin, either HIGH or LOW.
            /// </summary>
            /// <param name="pin">the number of the digital pin you want to read</param>
            /// <returns>HIGH or LOW</returns>
            public PinLevel Read (int pin) { return digitalRead(pin); }
            /// <summary>
            /// Write a HIGH or a LOW value to a digital pin.
            /// </summary>
            /// <param name="pin">the pin number</param>
            /// <param name="value">HIGH or LOW</param>
            public void Write (int pin, PinLevel value) { digitalWrite(pin, value); }
            /// <summary>
            /// Configures the specified pin to behave either as an input or an output.
            /// </summary>
            /// <param name="pin">the number of the pin whose mode you wish to set</param>
            /// <param name="mode">INPUT, OUTPUT, or INPUT_PULLUP</param>
            public void PinMode (int pin, DigitalPinMode mode) { pinMode(pin, mode); }
        }

        public class Analog
        {
            /// <summary>
            /// Reads the value from the specified analog pin.
            /// </summary>
            /// <param name="pin">the number of the analog input pin to read from (0 to 5 on most boards, 0 to 7 on the Mini and Nano, 0 to 15 on the Mega)</param>
            /// <returns>int(0 to 1023)</returns>
            public int Read (int pin) { return analogRead(pin); }
            /// <summary>
            /// Writes an analog value (PWM wave) to a pin.
            /// </summary>
            /// <param name="pin">the pin to write to.</param>
            /// <param name="value">the duty cycle: between 0 (always off) and 255 (always on).</param>
            public void Write (int pin, int value) { analogWrite(pin, value); }
            /// <summary>
            /// Configures the reference voltage used for analog input (i.e. the value used as the top of the input range).
            /// </summary>
            /// <param name="type">which type of reference to use</param>
            public void Reference(RefMode type) { analogReference(type); }
        }

        public class Resolution
        {

        }

        public class Advanced
        {

        }

        public class Time
        {
            /// <summary>
            /// Pauses the program for the amount of time (in milliseconds) specified as parameter. (There are 1000 milliseconds in a second.)
            /// </summary>
            /// <param name="ms">the number of milliseconds to pause</param>
            public void Delay(long ms) { delay(ms); }
            /// <summary>
            /// Pauses the program for the amount of time (in microseconds) specified as parameter. There are a thousand microseconds in a millisecond, and a million microseconds in a second.
            /// </summary>
            /// <param name="us">the number of microseconds to pause</param>
            public void DelayMicroseconds(int us) { delayMicroseconds(us); }
            /// <summary>
            /// Returns the number of microseconds since the Arduino board began running the current program. This number will overflow (go back to zero), after approximately 70 minutes.
            /// </summary>
            /// <returns>Returns the number of microseconds since the Arduino board began running the current program.</returns>
            public long Micros() { return micros(); }
            /// <summary>
            /// Returns the number of milliseconds since the Arduino board began running the current program. This number will overflow (go back to zero), after approximately 50 days.
            /// </summary>
            /// <returns>Number of milliseconds since the program started</returns>
            static long  Millis() { return millis(); }
        }






    }

    

    public static class Serial
    {
        public static void Begin(int baud)
        {

        }

        public static void Begin(int serial, int baud)
        {

        }

        public static void End()
        {

        }
    }
}
