﻿namespace Mwh.Sample.Domain.Tests.Extensions;

[TestClass]
public class TreeNodeTests
{
    [TestMethod]
    public void AddChild_ShouldAddChildNodeInSortedOrder()
    {
        // Arrange
        TreeNode<int> rootNode = new TreeNode<int>(5);

        // Act
        TreeNode<int> child1 = rootNode.AddChild(3);
        child1.AddChild(30);
        child1.AddChild(31);

        TreeNode<int> child2 = rootNode.AddChild(7);
        child2.AddChild(70);
        child2.AddChild(71);
        child2.AddChild(72);


        TreeNode<int> child3 = rootNode.AddChild(1);
        child3.AddChild(10);
        child3.AddChild(11);
        child3.AddChild(12);

        List<int> test = rootNode.EnumerateSelfAndDescendants().ToList();
        IEnumerable<(int Depth, int Value)> test2 = rootNode.EnumerateSelfAndDescendantsWithDepth();


        // Assert
        Assert.AreEqual(12, rootNode.EnumerateSelfAndDescendants().Count());
        Assert.AreEqual(5, rootNode.EnumerateSelfAndDescendants().ElementAt(0));
        Assert.AreEqual(1, rootNode.EnumerateSelfAndDescendants().ElementAt(1));
        Assert.AreEqual(10, rootNode.EnumerateSelfAndDescendants().ElementAt(2));
        Assert.AreEqual(0, rootNode.EnumerateSelfAndDescendantsWithDepth().ElementAt(0).Depth);
        Assert.AreEqual(1, rootNode.EnumerateSelfAndDescendantsWithDepth().ElementAt(1).Value);
    }

    [TestMethod]
    public void EnumerateSelfAndDescendants_ShouldReturnCorrectDepthAndValues()
    {
        // Arrange
        TreeNode<string> rootNode = new TreeNode<string>("A");
        TreeNode<string> child1 = rootNode.AddChild("B");
        TreeNode<string> child2 = rootNode.AddChild("C");
        TreeNode<string> child3 = child1.AddChild("D");
        TreeNode<string> child4 = child1.AddChild("E");

        // Act
        List<(int Depth, string Value)> result = rootNode.EnumerateSelfAndDescendantsWithDepth().ToList();

        // Assert
        Assert.AreEqual(5, result.Count);
        Assert.AreEqual(0, result[0].Depth);
        Assert.AreEqual("A", result[0].Value);
        Assert.AreEqual(1, result[1].Depth);
        Assert.AreEqual("B", result[1].Value);
        Assert.AreEqual(2, result[2].Depth);
        Assert.AreEqual("D", result[2].Value);
        Assert.AreEqual(2, result[3].Depth);
        Assert.AreEqual("E", result[3].Value);
        Assert.AreEqual(1, result[4].Depth);
        Assert.AreEqual("C", result[4].Value);
    }
}





