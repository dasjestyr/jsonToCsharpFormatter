using System;
using System.Collections.Generic;

namespace JsonPasteToJsonObjectFormatter
{
    public class ClassParser
    {
        private const string ClassSignature = "public class";
        
        public List<string> FindClasses(string input)
        {
            var classes = new List<string>();
            var classStart = 0;
            do
            {
                classStart = FindIndexOfNextClass(classStart, input);
                if (classStart == -1)
                    break;

                var closingBrace = FindIndexOfClosingBrace(classStart, input);

                var classContent = input.Substring(classStart, closingBrace - classStart + 1);
                classes.Add(classContent);

                classStart = FindIndexOfNextClass(closingBrace, input);

            } while (classStart > -1 && classStart < input.Length);

            return classes;
        }

        private static int FindIndexOfClosingBrace(int startingIndex, string input)
        {
            var indexOfNextClass = input.IndexOf(ClassSignature, startingIndex + 1, StringComparison.Ordinal);

            if (indexOfNextClass == -1)
                indexOfNextClass = input.Length - 1;

            for (var i = indexOfNextClass; i > 0; i--)
            {
                if (input[i] == '}')
                    return i;
            }

            return -1;
        }

        private static int FindIndexOfNextClass(int startingIndex, string input)
        {
            return input.IndexOf(ClassSignature, startingIndex, StringComparison.Ordinal);
        }
    }
}
