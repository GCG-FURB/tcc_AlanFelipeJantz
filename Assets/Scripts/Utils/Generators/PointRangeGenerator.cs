﻿using System.Collections.Generic;
using UnityEngine;

public static class PointRangeGenerator
{
    private static readonly List<PointRange> PointsRange = new List<PointRange>()
    {
        new PointRange(-10, 15, 15, 20),
        new PointRange(10, 20, 15, 45),
        new PointRange(10, 40, -15, 45),
        new PointRange(-10, 40, -15, 15),
    };

    private static readonly System.Random Randomizer = new System.Random();

    public static List<LevelPointRange> Generate(int pointsAmount, float heightMin, float heightMax)
    {
        var result = new List<LevelPointRange>();
        var usedRanges = new List<int>();

        for (int i = 0; i < pointsAmount; i++)
        {
            var index = Randomizer.Next(0, PointsRange.Count);

            if (usedRanges.Count < 4)
                while (usedRanges.Contains(index))
                    index = Randomizer.Next(0, PointsRange.Count);
            else
                usedRanges.Clear();
            usedRanges.Add(index);

            var range = PointsRange[index];

            result.Add(new LevelPointRange(new Vector3(range.Min.x, heightMin, range.Min.y), new Vector3(range.Max.x, heightMax, range.Max.y)));
        }

        return result;
    }

    private class PointRange
    {
        public Vector2 Min { get; private set; }
        public Vector2 Max { get; private set; }

        public PointRange(int minA, int maxA, int minB, int maxB)
        {
            Min = new Vector2(minA, maxA);
            Max = new Vector2(minB, maxB);
        }
    }
}
