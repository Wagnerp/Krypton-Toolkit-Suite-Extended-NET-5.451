﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.451/blob/master/LICENSE
 *
 */
#endregion

using System.Diagnostics;
using System.Drawing;

namespace ExtendedControls.Base.Code.Colours
{
    public sealed class RGBColour
    {
        #region Public static methods.
        // ------------------------------------------------------------------

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static RGBColour FromColour(Color colour)
        {
            return ColourConverting.ColourToRGB(colour);
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static RGBColour FromRgbColour(RGBColour colour)
        {
            return new RGBColour(colour.Red, colour.Green, colour.Blue);
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static RGBColour FromHSBColour(HSBColour colour)
        {
            return colour.ToRGBColour();
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static RGBColour FromHSLColour(HSLColour colour)
        {
            return colour.ToRGBColour();
        }

        // ------------------------------------------------------------------
        #endregion

        #region Public methods.
        // ------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbColor"/> class.
        /// </summary>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public RGBColour(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current 
        /// <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current 
        /// <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
                @"Red: {0}; green: {1}; blue: {2}", Red, Green, Blue);
        }

        /// <summary>
        /// Returns the underlying .NET color.
        /// </summary>
        /// <returns></returns>
        public Color ToColour()
        {
            return ColourConverting.RGBToColour(this);
        }

        /// <summary>
        /// Returns a RGB color.
        /// </summary>
        /// <returns></returns>
        public RGBColour ToRGBColour()
        {
            return this;
        }

        /// <summary>
        /// Returns a HSB color.
        /// </summary>
        /// <returns></returns>
        public HSBColour ToHSBColour()
        {
            return ColourConverting.RGBToHSB(this);
        }

        /// <summary>
        /// Returns a HSL color.
        /// </summary>
        /// <returns></returns>
        public HSLColour ToHSLColour()
        {
            return ColourConverting.RGBToHSL(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is 
        /// equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with 
        /// the current <see cref="T:System.Object"/>.</param>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the 
        /// current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">The 
        /// <paramref name="obj"/> parameter is null.</exception>
        public override bool Equals(
            object obj)
        {
            var equal = false;

            if (obj is RGBColour)
            {
                var rgb = (RGBColour)obj;

                if (Red == rgb.Red && Blue == rgb.Blue && Green == rgb.Green)
                {
                    equal = true;
                }
            }

            return equal;
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        public override int GetHashCode()
        {
            Debug.Assert(1 == 1);
            return base.GetHashCode();
        }

        // ------------------------------------------------------------------
        #endregion

        #region Public properties.
        // ------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the red component. Values from 0 to 255.
        /// </summary>
        /// <value>The red component.</value>
        public int Red
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the green component. Values from 0 to 255.
        /// </summary>
        /// <value>The green component.</value>
        public int Green
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the blue component. Values from 0 to 255.
        /// </summary>
        /// <value>The blue component.</value>
        public int Blue
        {
            get;
            set;
        }

        // ------------------------------------------------------------------
        #endregion
    }
}