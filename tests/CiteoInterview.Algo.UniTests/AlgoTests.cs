namespace CiteoInterview.Algo.UniTests;

public class AlgoTests
{
    [Fact]
    public void Test1()
    {
        var testAlgo = new TestAlgo();
        var result = testAlgo.Test1(new[] { "reza", "azer", "hello", "nat", "tan", "ante" })
            .ToList();
        Assert.Multiple(() =>
        {
            Assert.True(result.Count == 4);
            Assert.Contains(new List<string> {"azer", "reza"}, result );
            Assert.Contains(new List<string> {"hello"}, result);
            Assert.Contains(new List<string> {"nat","tan"}, result);
            Assert.Contains(new List<string> {"ante"}, result);
        });
    }

    [Fact]
    public void Test2()
    {
        var input = new List<List<int>>()
        {
            new() { 1,2,3,4,5,6,7,8,9},
            new() { 6,10,11,8,13,14,15,23},
            new() { 6,23,7,8},
            new() { 2,50,100,88},
        };
        var testAlgo = new TestAlgo();
        var result = testAlgo.Test2(input);
        Assert.Collection(result, items =>
        {
            Assert.Equal(items, new List<int> { 1,3,4,5,9} );
        },items =>
        {
            Assert.Equal(items, new List<int> { 10,11,13,14,15} );
        },items =>
        {
            Assert.Equal(items, new List<int>() );
        },items =>
        {
            Assert.Equal(items, new List<int> { 50,100,88} );
        });
    }
    
    [Fact]
    public void Test3()
    {
        var input = new [] {1, 2, 7, 8, 11, 7};
        var testAlgo = new TestAlgo();
        var result = testAlgo.Test3(input, 20);
        Assert.Collection(result, items =>
        {
            Assert.Equal(items, new List<int> { 1,8,11} );
        },items =>
        {
            Assert.Equal(items, new List<int> { 2,7,11} );
        });
    }
    
    [Fact]
    public void Test4()
    {
        var input = new []
        {
            "Card   1: 58 96 35 20 93 34 10 27 37 30 | 99 70 93 11 63 41 37 29  7 28 34 10 40 96 38 35 27 30 20 21  4 51 58 39 56",
            "Card   2: 64 84 57 46 53 86 90 99 59 70 | 99 59 30 83 84 70 31 57  6 29 18 82 15 88 86 53 51 64 32 47 44 46 80 39 90",
            "Card   3: 55 87 51 18 86  5 66 83 92 95 | 73 68 49 57 29 14 41 42 65 10 84 34 67 44  6 48 61 13 28 38 52 19 78 64 11",
            "Card   4: 52 21 59 78 18 42 46 91 31 10 | 48 83 13 68 42 72  4 10  6 36 63 81 21 94  8  3 78 53  2 47 62 77 56 97  7",
            "Card   5:  8 79 31  1 26 57 90 62 93 10 | 26 70 73  6 16 15 93 57 34 56 87 31 10 45  1 22 79 77 90 47 42 58 41 62  8",
            "Card   6: 90 75 24 69 81 93 39 38 96 33 |  2 78 68 31 99 35 49 66 36 84 54 27 43 80 50  3 22 74 60 98 57 83 13 82 91",
            "Card   7: 74 86 51 70 28 54  6 34 48 53 | 51 82 34 74 40 24 42 66 20 61 84 15 89 62 69 48 95 31 93 52 76 12 90 75 99"
        };
        var testAlgo = new TestAlgo();
        var result = testAlgo.Test4(input);
        Assert.Equal(1552, result);
    }
}