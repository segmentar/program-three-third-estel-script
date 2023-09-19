using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramEscapePortalSet(String[] stringArray, Tuple<String, String>[] tupleArray, Char character_ESCAPE, Char character_TERMINATOR)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var enumerator = stringArray.GetEnumerator();

            var zeroth = -1;

            do
            {
                zeroth = zeroth + 1;

                Boolean shouldBreak;

                shouldBreak = enumerator.MoveNext() is false;

                if (shouldBreak is true)
                {
                    break;
                }
                else
                    "false".ToString();

                String stringReflect;

                stringReflect = enumerator.Current as String;

                var boolean_match__MORE_THAN = (stringReflect.Length > 1);

                Boolean isLengthCheck;

                isLengthCheck = boolean_match__MORE_THAN is true;

                if (isLengthCheck)
                {
                    goto division_segment__SKIP;
                }
                else
                {
                    goto division_segment__RESOLVE;
                }

                division_segment__SKIP:
                {
                    Boolean isPortalCheck;

                    isPortalCheck = stringReflect.Contains(character_ESCAPE.ToString()) is true;

                    if (isPortalCheck)
                    {
                        continue;
                    }
                    else
                    {
                        collectionResult.Add(stringReflect);
                    }

                    continue;
                }

                division_segment__RESOLVE:
                {
                    var roth = (stringArray.Length - 1);

                    Boolean isLastCheck, shouldContinue;

                    isLastCheck = (zeroth == roth) is true;

                    shouldContinue = isLastCheck is true;

                    if (shouldContinue is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Tuple<String, String> tuple;

                    tuple = tupleArray[zeroth];

                    String left, right;

                    left = tuple.Item1;

                    right = tuple.Item2;

                    Char character;

                    character = left[0];

                    var boolean_contagious__PORTAL_is = true;

                    boolean_contagious__PORTAL_is = boolean_contagious__PORTAL_is && (character == character_ESCAPE) is true;

                    boolean_contagious__PORTAL_is = boolean_contagious__PORTAL_is && (right.Length > 1) is true;

                    boolean_contagious__PORTAL_is = boolean_contagious__PORTAL_is && right.Contains(character_ESCAPE.ToString()) is true;

                    Boolean isPortalCheck;

                    isPortalCheck = boolean_contagious__PORTAL_is is true;

                    if (isPortalCheck)
                    {
                        var split = right.Split(new String[] { character_ESCAPE.ToString() }, StringSplitOptions.None);;

                        var eoth = (split.Length - 1);

                        var last = split[eoth];

                        String stringItem;

                        switch (last)
                        {
                            case nameof(ArchitecturePageOneFirst.PathProgramOneFirst):
                                stringItem = ArchitecturePageOneFirst.PathProgramOneFirst;
                                break;

                            case nameof(ArchitecturePageOneFirst.PathProgramTwoSecond):
                                stringItem = ArchitecturePageOneFirst.PathProgramTwoSecond;
                                break;

                            case nameof(ArchitecturePageOneFirst.InputPathProgramOneFirst):
                                stringItem = ArchitecturePageOneFirst.InputPathProgramOneFirst;
                                break;

                            case nameof(ArchitecturePageOneFirst.InputPathProgramTwoSecond):
                                stringItem = ArchitecturePageOneFirst.InputPathProgramTwoSecond;
                                break;

                            case nameof(ArchitecturePageOneFirst.OutputPathProgramOneFirst):
                                stringItem = ArchitecturePageOneFirst.OutputPathProgramOneFirst;
                                break;

                            case nameof(ArchitecturePageOneFirst.OutputPathProgramTwoSecond):
                                stringItem = ArchitecturePageOneFirst.OutputPathProgramTwoSecond;
                                break;

                            default:
                                stringItem = last;
                                break;
                        }

                        var period = Convert.ToChar(46);

                        var align_LENGTH = stringItem.Length;

                        var align_FORMAT = stringItem.TrimStart(period).Length;

                        var align_DIFFERENCE = (align_LENGTH - align_FORMAT);

                        var boolean_match__EQUAL_THAN = (align_DIFFERENCE == ImmutablePageOneFirst.FilesystemNotationDirectoryOrigin.Length);

                        Boolean isPathCheck;

                        isPathCheck = boolean_match__EQUAL_THAN is true;

                        if (isPathCheck)
                        {
                            stringItem = ForgeSpecialPath(stringItem, true);
                        }
                        else
                            "false".ToString();

                        var whitespace = Convert.ToChar(32);

                        var result = stringItem.Split();

                        Char[] characterArray;

                        characterArray = new Char[] { character_ESCAPE, whitespace };

                        var separator = new String(characterArray);

                        var length = (split.Length - 1);

                        String[] splitArray;

                        splitArray = new String[length];

                        Array.Copy(split, 0, splitArray, 0, length);

                        var result_JOIN_left = String.Join(String.Empty, splitArray);

                        var result_JOIN_right = String.Join(separator.ToString(), result);

                        var result_JOIN = (result_JOIN_left + result_JOIN_right + character_TERMINATOR);

                        collectionResult.Add(left);

                        collectionResult.Add(result_JOIN);
                    }
                    else
                    {
                        collectionResult.Add(left);
                    }

                    continue;
                }

            } while (true);

            return new List<String>(collectionResult);
        }
    }
}
