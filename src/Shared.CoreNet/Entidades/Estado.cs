using System;
using System.Linq;
using System.Xml.Serialization;

namespace CoreNet.Entidades
{
    public enum Estado
    {
        [XmlEnum("12")]
        AC = 12,

        [XmlEnum("27")]
        AL = 27,

        [XmlEnum("16")]
        AP = 16,

        [XmlEnum("13")]
        AM = 13,

        [XmlEnum("29")]
        BA = 29,

        [XmlEnum("23")]
        CE = 23,

        [XmlEnum("53")]
        DF = 53,

        [XmlEnum("32")]
        ES = 32,

        [XmlEnum("52")]
        GO = 52,

        [XmlEnum("21")]
        MA = 21,

        [XmlEnum("51")]
        MT = 51,

        [XmlEnum("50")]
        MS = 50,

        [XmlEnum("31")]
        MG = 31,

        [XmlEnum("15")]
        PA = 15,

        [XmlEnum("25")]
        PB = 25,

        [XmlEnum("41")]
        PR = 41,

        [XmlEnum("26")]
        PE = 26,

        [XmlEnum("22")]
        PI = 22,

        [XmlEnum("33")]
        RJ = 33,

        [XmlEnum("24")]
        RN = 24,

        [XmlEnum("43")]
        RS = 43,

        [XmlEnum("11")]
        RO = 11,

        [XmlEnum("14")]
        RR = 14,

        [XmlEnum("42")]
        SC = 42,

        [XmlEnum("35")]
        SP = 35,

        [XmlEnum("28")]
        SE = 28,

        [XmlEnum("17")]
        TO = 17,

        [XmlEnum("91")]
        AN = 91,

        [XmlEnum("99")]
        EX = 99
    }

    public static class ExtEstadoUF
    {
        public static Estado SiglaParaEstado(this Estado estado, string siglaUf)
        {
            var enumValues = Enum.GetValues(typeof(Estado)).Cast<Estado>().FirstOrDefault(e => e.GetSiglaUfString() == siglaUf);

            return enumValues;
        }

        public static Estado CodigoIbgeParaEstado(this Estado estado, string codigoIbge)
        {
            var enumValues = Enum.GetValues(typeof(Estado)).Cast<Estado>().FirstOrDefault(est => est.GetCodigoIbgeEmString() == codigoIbge);

            return enumValues;
        }

        public static string GetSiglaUfString(this Estado estado)
        {
            return estado.ToString();
        }

        public static string GetCodigoIbgeEmString(this Estado estado)
        {
            var codigo = (byte)estado;
            return codigo.ToString();
        }

        public static byte GetCodigoIbgeEmByte(this Estado estado)
        {
            var codigo = (byte)estado;

            return codigo;
        }
    }
}
