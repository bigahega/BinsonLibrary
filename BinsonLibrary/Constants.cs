using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinsonLibrary
{
    /**
        Low level constants: see the Bison specification
    **/
    class Constants
    {
        public const int BEGIN = 0x40;
        public const int END = 0x41;
        public const int BEGIN_ARRAY = 0x42;
        public const int END_ARRAY = 0x43;

        public const int BOOLEAN = 0x44;
        public const int FALSE = 0x44;
        public const int TRUE = 0x45;
        public const int DOUBLE = 0x46;

        public const int INTEGER = 0x10;
        public const int INTEGER1 = 0x10;
        public const int INTEGER2 = 0x11;
        public const int INTEGER4 = 0x12;
        public const int INTEGER8 = 0x13;

        public const int STRING = 0x14;
        public const int STRING1 = 0x14;
        public const int STRING2 = 0x15;
        public const int STRING4 = 0x16;
        public const int STRING8 = 0x17;

        public const int BYTES = 0x18;
        public const int BYTES1 = 0x18;
        public const int BYTES2 = 0x19;
        public const int BYTES4 = 0x1a;
        public const int BYTES8 = 0x1b;

        public const int INT_LENGTH_MASK = 0x03;
        public const int ONE_BYTE = 0x00;
        public const int TWO_BYTES = 0x01;
        public const int FOUR_BYTES = 0x02;
        public const int EIGHT_BYTES = 0x03;

        public const long TWO_TO_7 = 128;
        public const long TWO_TO_15 = 32768;
        public const long TWO_TO_31 = 2147483648L;

        public const int BOOLEAN_CLASSNAME_LENGTH = 17;
        public const int LONG_CLASSNAME_LENGTH = 14;
        public const int DOUBLE_CLASSNAME_LENGTH = 16;
        public const int STRING_CLASSNAME_LENGTH = 16;
        public const int BYTES_CLASSNAME_LENGTH = 2;
        public const int BINSON_OBJECT_CLASSNAME_LENGTH = 17;
        public const int BINSON_ARRAY_CLASSNAME_LENGTH = 22;
    }
}
