using System.Text;

namespace ObjectOrientedPatterns.Creational.Builder
{
    // see https://en.wikipedia.org/wiki/Builder_pattern

    // Director
    public class Choreographer
    {
        IChoreographyBuilder myChoreoBuilder;
        public Choreographer(IChoreographyBuilder choreoBuilder)
        {
            myChoreoBuilder = choreoBuilder;
        }
        public void StandardChoreo()
        {
            myChoreoBuilder.MoveArms();
            myChoreoBuilder.MoveHead();
            myChoreoBuilder.MoveArms();
            myChoreoBuilder.MoveLegs();
            myChoreoBuilder.Clap();
        }
    }

    // interface Builder
    public interface IChoreographyBuilder
    {
        public void Clap();
        public void MoveArms();
        public void MoveLegs();
        public void MoveHead();
    }

    // ConcreteBuilder
    public class MetalChoreoBuilder : IChoreographyBuilder
    {
        // Our complex object in this case is just a string
        public string GetChoreo() => myBuild.ToString();
        public void Clap() => myBuild.AppendLine("Smashing your hands together");
        public void MoveArms() => myBuild.AppendLine("Wildly swinging your arms");
        public void MoveLegs() => myBuild.AppendLine("Furiously kicking around");
        public void MoveHead() => myBuild.AppendLine("Banging your head up and down");

        private StringBuilder myBuild = new();
    }

    // ConcreteBuilder
    public class ClassicChoreoBuilder : IChoreographyBuilder
    {
        // Note that we could have a different complex object depending on the builder
        public string GetChoreo() => myBuild.ToString();
        public void Clap() => myBuild.AppendLine("Clapping your hands");
        public void MoveArms() => myBuild.AppendLine("Waving your arms");
        public void MoveHead() => myBuild.AppendLine("Turning your head");
        public void MoveLegs() => myBuild.AppendLine("Moving around");

        private StringBuilder myBuild = new();
    }
}
