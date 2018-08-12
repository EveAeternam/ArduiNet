using System;
using System.Collections.Generic;
using System.Text;
using ArduiNET;

namespace ArduiNET
{
    public enum PinLevel { LOW, HIGH }
    public enum DigitalPinMode { OUTPUT, INPUT_PULLUP, INPUT }
    public enum BuiltIn { LED_BUILTIN }
    public enum RefMode { DEFAULT, INTERNAL, INTERNAL1V1, INTERNAL2V56, EXTERNAL, AR_DEFAULT, AR_INTERNAL, AR_INTERNAL1V0, AR_INTERNAL1V65, AR_INTERNAL2V23, AR_EXTERNAL }

    public class Monoduino
    {
        public static void Setup() { }
        public static void Loop() { }

        // DIGITAL I/O
        public static PinLevel digitalRead (int _pin) {
            return 0;
        }
        public static void digitalWrite (int _pin, PinLevel _value) {
            
        }
        public static void pinMode (int _pin, DigitalPinMode _mode) {

        }

        // ANALOG I/O
        public static int analogRead (int _pin) {
            return 0;
        }
        public static void analogReference (RefMode _type)
        { }
        public static void analogWrite (int _pin, int _value)
        { }

        // Zero, Due & MKR Family
        public static void analogReadResolution () { }
        public static void analogWriteResolution () { }

        // ADVANCED I/O
        public static void noTone (int pin) { }
        public static void pulseIn (int pin) { }
        public static void pulseInLong (int pin) { }
        public static void shiftIn (int pin) { }
        public static void shiftOut (int pin) { }
        public static void tone (int pin) { }

        // TIME
        public static void delay (long _ms) { }
        public static void delayMicroseconds (int _us) { }
        public static long micros () { return 0; }
        public static long millis () { return 0; }

        // MATH
        public static void abs (int val) { }
        public static void constrain (int val) { }
        public static void map (int val) { }
        public static void max (int val) { }
        public static void min (int val) { }
        public static void pow (int val) { }
        public static void sq (int val) { }
        public static void sqrt (int val) { }

        // TRIG
        public static void cos (int val) { }
        public static void sin (int val) { }
        public static void tan (int val) { }

        // CHARACTERS
        public static void isAlpha (int val) { }
        public static void isAlphaNumeric (int val) { }
        public static void isAscii (int val) { }
        public static void isControl (int val) { }
        public static void isDigit (int val) { }
        public static void isGraph (int val) { }
        public static void isHexadecimalDigit (int val) { }
        public static void isLowerCase (int val) { }
        public static void isPrintable (int val) { }
        public static void isPunct (int val) { }
        public static void isSpace (int val) { }
        public static void isUpperCase (int val) { }
        public static void isWhitespace (int val) { }

        // RANDOM NUMBER GENERATION
        public static void random (int val) { }
        public static void randomSeed (int val) { }

        // BITS AND BYTES
        public static void bit (int val) { }
        public static void bitClear (int val) { }
        public static void bitRead (int val) { }
        public static void bitSet (int val) { }
        public static void bitWrite (int val) { }
        public static void highByte (int val) { }
        public static void lowByte (int val) { }

        // EXTERNAL INTERRUPTS
        public static void attachInterrupt (int val) { }
        public static void detachInterrupt (int val) { }

        // INTERRUPTS
        public static void interrupts (int val) { }
        public static void noInterrupts (int val) { }

        // COMMUNICATIONS
        public static void Serial (int val) { }
        public static void stream (int val) { }

        // USB
        public static void Keyboard (int val) { }
        public static void Mouse (int val) { }
    }
}