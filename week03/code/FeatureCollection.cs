public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public class Geometry
{
    public double[] Coordinates { get; set; }
}

public class Properties
{
    public string Place { get; set; }
    public double Mag { get; set; }
}

public class Feature
{
    public Geometry Geometry { get; set; }
    public Properties Properties { get; set; }
}
    public List<Feature> Features { get; set; }

}