using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingTool.ExtensionMethods
{

    public static class CustomExtensions
    {

        public static byte[] ToByteArray(this Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        public static int? ParseNullableInt(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return value.ParseInt();
        }

        public static int ParseInt(this string value) //int defaultIntValue = 0)
        {
            int parsedInt;
            if (int.TryParse(value, out parsedInt))
            {
                return parsedInt;
            }

            return default(int);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   A string extension method that parse nullable decimal. </summary>
        ///
        /// <remarks>   SUJAY, 11-01-2018. </remarks>
        ///
        /// <param name="value">    The value to act on. </param>
        ///
        /// <returns>   A decimal? </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static decimal? ParseNullableDecimal(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return value.ParseDecimal();
        }

        public static decimal ParseDecimal(this string value)
        {
            decimal parsedDecimal;
            if (decimal.TryParse(value, out parsedDecimal))
            {
                return parsedDecimal;
            }

            return default(decimal);
        }

    }





}
