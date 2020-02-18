using System;

namespace ClienteConcentrador
{
    public static class CodigosRespuesta
    {
        public static int OK;

        public static int ERROR_PERSISTENDO_DATOS;

        public static int TERMINAL_SOLICITA_ARCHIVO_INEXISTENTE;

        public static int FUERA_DE_RANGO_HORARIO;

        public static int SISTEMA_EMPRESA_NO_CONFIGURADO;

        public static int ERROR_GENERICO;

        static CodigosRespuesta()
        {
            CodigosRespuesta.OK = 0;
            CodigosRespuesta.ERROR_PERSISTENDO_DATOS = 1;
            CodigosRespuesta.TERMINAL_SOLICITA_ARCHIVO_INEXISTENTE = 2;
            CodigosRespuesta.FUERA_DE_RANGO_HORARIO = 4;
            CodigosRespuesta.SISTEMA_EMPRESA_NO_CONFIGURADO = 10;
            CodigosRespuesta.ERROR_GENERICO = 11;
        }
    }
}