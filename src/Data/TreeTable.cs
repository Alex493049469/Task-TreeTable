namespace TreeTableTest.Data
{
    public class TreeTableNode
    {
        public int VerticalSpan { get; set; }
        public string Color { get; set; }
        public string Value { get; set; }
        public List<TreeTableNode> Children { get; set; } = new List<TreeTableNode>();
    }

    public class TreeTable
    {
        public string Name { get; set; }
        public List<TreeTableNode> Children { get; set; } = new List<TreeTableNode>();
    }

    public static class TableTreeDefault
    {
        public static TreeTable DefaultTreeTable => new TreeTable
        {
            Name = "Table",
            Children = new List<TreeTableNode>
            {
                new TreeTableNode
                {
                    VerticalSpan = 1,
                    Color = "Orange",
                    Value = "1",
                    Children = new List<TreeTableNode>
                    {
                        new TreeTableNode
                        {
                            VerticalSpan = 1,
                            Color = "Green",
                            Value = "4",
                            Children = new List<TreeTableNode>
                            {
                                new TreeTableNode
                                {
                                    VerticalSpan = 1,
                                    Color = "Purple",
                                    Value = "7",
                                    Children = new List<TreeTableNode>()
                                }
                            }
                        },
                        new TreeTableNode
                        {
                            VerticalSpan = 1,
                            Color = "Green",
                            Value = "5",
                            Children = new List<TreeTableNode>
                            {
                                new TreeTableNode
                                {
                                    VerticalSpan = 1,
                                    Color = "Purple",
                                    Value = "8",
                                    Children = new List<TreeTableNode>()
                                }
                            }
                        }
                    }
                },
                new TreeTableNode
                {
                    VerticalSpan = 1,
                    Color = "Orange",
                    Value = "2",
                    Children = new List<TreeTableNode>
                    {
                        new TreeTableNode
                        {
                            VerticalSpan = 2,
                            Color = "Green",
                            Value = "6",
                            Children = new List<TreeTableNode>()
                        }
                    }
                },
                new TreeTableNode
                {
                    VerticalSpan = 2,
                    Color = "Orange",
                    Value = "3",
                    Children = new List<TreeTableNode>
                    {
                        new TreeTableNode
                        {
                            VerticalSpan = 1,
                            Color = "Purple",
                            Value = "9",
                            Children = new List<TreeTableNode>()
                        },
                        new TreeTableNode
                        {
                            VerticalSpan = 1,
                            Color = "Purple",
                            Value = "10",
                            Children = new List<TreeTableNode>()
                        }
                    }
                }
            }
        };
    }

}
