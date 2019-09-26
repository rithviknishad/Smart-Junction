using System;
using System.Collections.Generic;

namespace GUI.Simulation.Geometry
{

    /// <summary>
    /// Angle Datatype, Author: RITHVIK NISHAD
    /// </summary>
    /// * NOTE: ANGLE RANGE IS LIMITED TO [-360 DEG, 360 DEG]
    /// * ANGLE VALUE EXCEEDING THE ABOVE RANGE WILL BE AUTOMATICALLY CORRECTED TO WITHIN THIS RANGE
    public class Angle
    {
        /// <summary>
        /// Preset angle object -> 0 degrees
        /// </summary>
        public static Angle A0 = new Angle(0, Unit.Degrees);

        /// <summary>
        /// Preset angle object -> 90 degrees
        /// </summary>
        public static Angle A90 = new Angle(90, Unit.Degrees);

        /// <summary>
        /// Preset angle object -> 180 degrees
        /// </summary>
        public static Angle A180 = new Angle(180, Unit.Degrees);

        /// <summary>
        /// Preset angle object -> 270 degrees
        /// </summary>
        public static Angle A270 = new Angle(270, Unit.Degrees);

        /// <summary>
        /// Angle measurement units supported by this library for calculations
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Angle measurement unit: Degrees
            /// </summary>
            Degrees,
            /// <summary>
            /// Angle measurement unit: Radians
            /// </summary>
            Radians,
            /// <summary>
            /// Angle measurement unit: Revolutions
            /// </summary>
            Revolutions
        }

        /// <summary>
        /// Stores the value -> Radian divided by Math.PI in the variable, so as to ensure lossless compression and have higher precision over the value.
        /// Although Angle class is designed for limited range, this facility has been included as for code-reusability and future extendability purpose.
        /// </summary>
        public double _radByPI { get; private set; } = 0;

        /// <summary>
        /// Gets and sets the angle value, in Radian measure
        /// </summary>
        public double Radian
        {
            get => (_radByPI %= 2) * Math.PI;
            set => _radByPI = (value / Math.PI) % 2;
        }

        /// <summary>
        /// Gets and sets the angle value, in Degree measure
        /// </summary>
        public double Degree
        {
            get => (_radByPI %= 2) * 180;
            set => _radByPI = (value % 360) / 180;
        }

        /// <summary>
        /// Gets and sets the angle value, in Revolution measure
        /// </summary>
        public double Revolution
        {
            get => (_radByPI %= 2) / 2;
            set => _radByPI = (value % 1) * 2;
        }

        
        /// <summary>
        /// Returns the value of the anlge in specified unit
        /// </summary>
        /// <param name="unit">Unit of angle measurement in which value is to be returned</param>
        /// <returns>double</returns>
        public double Value(Unit unit) => (unit == Unit.Degrees ? Degree : (unit == Unit.Radians ? Radian : Revolution));


        /// <summary>
        /// Creates an Angle object with its angle value and unit specified
        /// </summary>
        /// <param name="value">Angle value</param>
        /// <param name="unit">Unit of angle value</param>
        public Angle(double value, Unit unit) => Radian = (unit == Unit.Radians ? value : (unit == Unit.Degrees ? DegToRad(value) : (unit == Unit.Revolutions ? RevToRad(value) : 0)));
        /// <summary>
        /// Creates an Angle object with another angle specified
        /// </summary>
        /// <param name="angle">Angle object of whose angle is to be copied into</param>
        public Angle(Angle angle) => _radByPI = angle._radByPI;

        /// <summary>
        /// turns / increases this angle by a specified angle
        /// </summary>
        /// <param name="angle">delta Angle</param>
        /// <returns>Angle</returns>
        public Angle Turn(Angle angle) => new Angle(Radian += angle.Radian, Unit.Radians);

        /// <summary>
        /// turns / increases this angle by a specified angle value and it's unit
        /// </summary>
        /// <param name="value">angle value</param>
        /// <param name="unit">angle unit</param>
        /// <returns></returns>
        public Angle Turn(double value, Unit unit) => Turn(new Angle(value, unit));

        /// <summary>
        /// turns this angle by 90 degree towards right
        /// (angle -= 90 degree)
        /// </summary>
        public Angle TurnRight => Turn(-90, Unit.Degrees);

        /// <summary>
        /// turns this angle by 90 degree towards left
        /// (angle += 90 degree)
        /// </summary>
        public Angle TurnLeft => Turn(90, Unit.Degrees);

        /// <summary>
        /// turns this angle by 180 degree (through left)
        /// (angle += 180 degree)
        /// </summary>
        public Angle TurnBack => Turn(180, Unit.Degrees);


        public override bool Equals(object obj) => obj.GetType() == GetType() ? ((Angle)obj == this) : false;

        public override int GetHashCode() => (int)Math.Pow(_radByPI, _radByPI);

        public override string ToString() => Degree.ToString() + " degree";


        /// -------------------------- <<-     A R I T H M E T I C   O P E R A T I O N S   O N   A N G L E     ->> --------------------------


        /// <summary>
        /// Returns the sum of two angles
        /// </summary>
        /// <param name="a1">angle 1</param>
        /// <param name="a2">angle 2</param>
        /// <returns>Angle</returns>
        public static Angle operator +(Angle a1, Angle a2) => new Angle(a1.Radian + a2.Radian, Unit.Radians);

        /// <summary>
        /// Returns the angle when multiplied by a numerical factor
        /// </summary>
        /// <param name="angle">angle</param>
        /// <param name="factor">multiplication factor</param>
        /// <returns>Angle</returns>
        public static Angle operator *(Angle angle, double factor) => new Angle(angle.Revolution * factor, Unit.Revolutions);
        /// <summary>
        /// Returns the angle when multiplied by a factor
        /// </summary>
        /// <param name="factor">multiplication numerical factor</param>
        /// <param name="angle">angle</param>
        /// <returns>Angle</returns>
        public static Angle operator *(double factor, Angle angle) => angle * factor;

        /// <summary>
        /// Returns the angle when divided by a numerical factor
        /// </summary>
        /// <param name="angle">angle</param>
        /// <param name="factor">division factor</param>
        /// <returns>Angle</returns>
        public static Angle operator /(Angle angle, double factor) => new Angle(angle * (1 / (factor != 0 ? factor : 1)));

        /// <summary>
        /// Returns a numerical factor when an angle is divided by another angle
        /// </summary>
        /// <param name="a1">angle (numerator)</param>
        /// <param name="a2">angle (denominator)</param>
        /// <returns></returns>
        public static double operator /(Angle a1, Angle a2) => a1._radByPI / a2._radByPI;

        /// <summary>
        /// Returns the negative of an angle
        /// </summary>
        /// <param name="angle">angle</param>
        /// <returns>Angle</returns>
        public static Angle operator -(Angle angle) => angle * -1;

        /// <summary>
        /// Subtracts angle (right) from angle (left)
        /// </summary>
        /// <param name="a1">angle (left)</param>
        /// <param name="a2">angle (right)</param>
        /// <returns>Angle</returns>
        public static Angle operator -(Angle a1, Angle a2) => new Angle(a1 + (-a2));

        /// <summary>
        /// Returns the remainder of an angle
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static Angle operator %(Angle a1, Angle a2) => new Angle(a1.Radian % a2.Radian, Unit.Radians);

        public static bool operator ==(Angle angle1, Angle angle2) => angle1._radByPI == angle2._radByPI;

        public static bool operator !=(Angle angle1, Angle angle2) => !(angle1 == angle2);

        /// _________________________________________________________________________________________________________________________________


        /// -------------------------- <<-             A N G L E   U N I T   C O N V E R S I O N S             ->> --------------------------


        /// <summary>
        /// Converts a given degree measure into radian measure
        /// </summary>
        /// <param name="degree">value in degrees</param>
        /// <returns>double</returns>
        public static double DegToRad(double degree) => Math.PI * (degree / 180);
        /// <summary>
        /// Converts a given degree measure into revolution measure
        /// </summary>
        /// <param name="degree">value in degrees</param>
        /// <returns>double</returns>
        public static double DegToRev(double degree) => degree / 360;

        /// <summary>
        /// Converts a given radian measure into degree measure
        /// </summary>
        /// <param name="radian">value in radians</param>
        /// <returns>double</returns>
        public static double RadToDeg(double radian) => (180 * radian) / Math.PI;
        /// <summary>
        /// Converts a given radian measure into revolution measure
        /// </summary>
        /// <param name="radian">value in radians</param>
        /// <returns>double</returns>
        public static double RadToRev(double radian) => radian / (2 * Math.PI);

        /// <summary>
        /// Converts a given revolution measure into radian measure
        /// </summary>
        /// <param name="revolution">value in revolution</param>
        /// <returns>double</returns>
        public static double RevToRad(double revolution) => revolution * 2 * Math.PI;
        /// <summary>
        /// Converts a given revolution measure into degree measure
        /// </summary>
        /// <param name="revolution">value in revolution</param>
        /// <returns>double</returns>
        public static double RevToDeg(double revolution) => revolution * 360;

        /// _________________________________________________________________________________________________________________________________

    }

}
