using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GUI.Simulation.Geometry;
using GUI.Simulation.Vehicles;

namespace GUI.Simulation.Terrains
{
    //public static class World
    //{

    //    public static Rectangle2D ActiveBoundRegion { get; private set; } = new Rectangle2D(10000, 10000, Point2D.Origin, Angle.A0);

    //    public static List<object> Objects = new List<object>();

        

    //    /// <summary>
    //    /// Returns all vehicles inside the specified bound region
    //    /// </summary>
    //    /// <param name="boundRegion">bound region</param>
    //    /// <returns>List of Vehicle</returns>
    //    public static List<Vehicle> Vehicles(Rectangle2D boundRegion)
    //    {
    //        List<Vehicle> req_List = new List<Vehicle>();

    //        foreach (object obj in Objects)
    //        {
    //            if (obj is Vehicle)
    //            {
    //                if (boundRegion.PointLiesInside(((Vehicle)obj).Position))
    //                {
    //                    req_List.Add((Vehicle)obj);
    //                }
    //            }
    //        }

    //        return req_List;
    //    }

    //    /// <summary>
    //    /// Returns all vehicles inside the specified bound regions
    //    /// </summary>
    //    /// <param name="boundRegions">multiple bound regions</param>
    //    /// <returns>List of Vehicle</returns>
    //    public static List<Vehicle> Vehicles(Rectangle2D[] boundRegions)
    //    {
    //        List<Vehicle> req_List = new List<Vehicle>();

    //        foreach (Rectangle2D boundRegion in boundRegions)
    //        {
    //            req_List.AddRange(Vehicles(boundRegion));
    //        }

    //        return req_List;
    //    }

    //    /// <summary>
    //    /// Returns all vehicles in the bound: ActiveBoundRegion
    //    /// </summary>
    //    /// <returns>List of Vehicle</returns>
    //    public static List<Vehicle> Vehicles() => Vehicles(ActiveBoundRegion);


    //}
}
