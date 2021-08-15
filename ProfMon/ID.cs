using ProfMon.Framework.ID;
using System;

namespace ProfMon {
    public class ID : IID {
        public IID.Part Major { get; }

        public IID.Part Minor { get; }

        public ID (byte[] major, byte[] minor = null) {
            Major = major;
            Minor = minor;
        }

        public ID (int major, int minor)
            : this(BitConverter.GetBytes(major),
                  BitConverter.GetBytes(minor)) { }

        public override bool Equals (object obj) {
            if(!(obj is IID)) {
                return false;
            }
            
            var other = obj as IID;

            return other.ToByteArray() == ToByteArray();
        }

        public override int GetHashCode () {
            return Major.GetHashCode() ^ Minor.GetHashCode();
        }

        public override string ToString () {
            return Major.ToString() + (Minor != 0 ? Minor.ToString() : "");
        }

        public byte[] ToByteArray () {
            byte[] major = Major;
            byte[] minor = Minor;

            byte[] id = new byte[major.Length + minor.Length];

            major.CopyTo(id, 0);
            minor.CopyTo(id, major.Length);

            return id;
        }
    }
}
