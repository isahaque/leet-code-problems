// See https://aka.ms/new-console-template for more information

using remove_duplicate;

var result= DuplicateRemover.Remove(new int[] {1,1,2});
Console.WriteLine(result);

var appearTwice = DuplicateRemover.RemoveIfAppearAtmostTwice(new int[] { 1, 1, 1,2,2,3 });
Console.WriteLine(appearTwice);