using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GhostEdit.Tests
{
    [TestClass()]
    public class GhostTests
    {
        [TestMethod()]
        public void CreatePostTest()
        {
            Ghost ghost = new Ghost("INSERT:TOKEN"); 
            Assert.IsTrue(ghost.CreatePost(new GhostData()
            {
                Posts = new Post[1]
             {
                new Post()
                {
                 Authors = new string[]{"walk.marcel.97@googlemail.com" },
                 CustomExcerpt = "If you can see this my unit test worked",
                  FeatureImage =new Uri("https://images.unsplash.com/photo-1600043940821-7092e669e839?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=631&q=80"),
                   Title ="UnitTest",
                   Tags = new string[]{"Getting Started"},
                   Html = "<h1>Welcome</h1><p>This was posted from a UnitTest</p>"
                }
             }
            })); ;
        }
    }
}