using CylinderProject.Models;

namespace CylinderTestCode
{
    public class UnitTest1
    {
        [Fact]
        public void IsValidCylinder()
        {
            Cylinder cylinder = new Cylinder(5, 8);
            Assert.Equal(5, cylinder.Radius);
            Assert.Equal(8, cylinder.Height);
        }

        [Fact]
        public void ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(0, 0));
        }

        [Fact]
        public void IsValidReturn()
        {
            Cylinder cylinder1 = new Cylinder(5, 4);
            Assert.Equal(Math.Round(282.743338823), Math.Round(cylinder1.GetSurfaceArea()));

            Assert.Equal(Math.Round(314.159265359), Math.Round(cylinder1.GetVolume()));
        }


        [Fact]
        public void IsValidResize()
        {
            Cylinder resizeCylinder = new Cylinder(5, 4);
            resizeCylinder.Resize(10, 8);
            Assert.Equal(10, resizeCylinder.Radius);
            Assert.Equal(8, resizeCylinder.Height);
        }

        [Fact]
        public void IsResizeThrowsException()
        {
            Cylinder resizeCylinderEx = new Cylinder(5, 4);
            Assert.Throws<ArgumentException>(() => resizeCylinderEx.Resize(0, -1));

        }

        [Fact]
        public void IsCylinderNull()
        {
            Cylinder cylindernull = new Cylinder(5, 4);
            Assert.NotNull(cylindernull);
        }

        [Fact]
        public void IsCylinderAssertInRange()
        {
            Cylinder cylinderinrange = new Cylinder(2, 3);
            Assert.InRange(cylinderinrange.Radius, 1, 100);
        }



    }
}