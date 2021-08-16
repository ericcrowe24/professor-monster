using System;

namespace ProfMon.Framework {
    public interface IID {
        Part Major { get; }
        Part Minor { get; }

        bool Equals (object obj);

        int GetHashCode ();

        string ToString ();

        byte[] ToByteArray ();

        public class Part {
            protected readonly byte[] _value;

            private Part () { }

            private Part (byte[] value) {
                _value = value;
            }

            public static implicit operator Part (byte[] value) => PartFromByteArray(value);

            private static Part PartFromByteArray (byte[] value) {
                if (value.Length > 4) {
                    throw new Exception("ID parts must be less than or equal to 4 bytes in length");
                }

                return new Part(value);
            }

            public static implicit operator Part (int value) => new Part(BitConverter.GetBytes(value));

            public static implicit operator byte[] (Part part) => part._value;

            public static implicit operator int (Part part) => ToInt(part);

            private static int ToInt (Part part) {
                byte[] p = part;

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(p);
                }

                return BitConverter.ToInt32(p, 0);
            }
        }
    }
}
