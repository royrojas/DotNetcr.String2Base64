# String2Base64
Ejemplo para convertir un texto a Base64 y convertir Base64 a texto

        /// <summary>
        /// Convierte string en Base64 a texto
        /// </summary>
        /// <param name="valor">Valor a reemplazar</param>
        /// <returns></returns>
        public static string DecodeBase64ToString(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            return myStr;
        }

        /// <summary>
        /// Convierte texto string en Base64
        /// </summary>
        /// <param name="valor">Valor a reemplazar</param>
        /// <returns></returns>
        public static string EncodeStrToBase64(string valor)
        {
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(valor);
            string myBase64 = Convert.ToBase64String(myByte);
            return myBase64;
        }
