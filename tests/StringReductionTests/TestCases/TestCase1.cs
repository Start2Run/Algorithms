﻿// ==========================================================================
// <copyright file="TestCase1Data.cs" company="Genetec">
//   Copyright (c) 2018 by Genetec
//   All rights reserved. May be used only in accordance with a valid Source Code License Agreement.
// </copyright>
// Created: 01/03/2021
// Last update: 01/03/2021
// ==========================================================================

namespace StringReductionUnitTests.TestCases
{
    public static class TestCase1
    {
        public static TestCaseModel Model => new TestCaseModel { 
            TestCasesCount = 100,
            Data = 
            @"
            babcbbaabcbcbcbaabbccaacccbbbcaaacabbbbaaaccbcccacbbccaccbbaacaccbabcaaaacaccacbaacc
            accbaacabbbaacabcbcaccaabcbccbacbcbaabacacababcaacbcccbaccacaabcbaaccbcabccbccbcbbcba
            ccaacbabbccbcca
            cbcbabccaaaacbbbcccbbb
            aaacacaacccbcbacccbacacbaabcc
            acabcbbcbabbabcacbaaccb
            ccaacaaccabccacabbcbabccbaabacbcccabcaaabaabaccbbaaccacaababbcbacbbcccaccababbccbac
            accbacbbcccccaccaababcbccacabbbcbbbcbcbbcaabbbccbaaabbaaaaabcabbcaabacacaaccbbbaccbaacbbcaaba
            aaccbccbccabbcc
            acccabcccbcaaacbacbcbabbccacb
            ccaabacaacccaaaacaaaacacaabbcccaccbbaaabcababcbaacbbbcbabccaacbaccccaabbbbbcaabbcabcacabcccab
            aabaaabc
            caacbbaabbbbcbbbbbabaccbcaccbcbbabccacc
            bbbbaacbcbaaaabaabcaaacbab
            acbcbacaacaccbacabbacabcbccacbbaacacaccaccaccacccbabcbcabcabaccbcaacaaabaabcbacacacbcbcbaaabaccaaaac
            baccbcabacbbccaabcbaacaaabbacacbbcaacbbcbaaaacaabcabcbbccaacbaaaabaaacacaccabbbaabcacbacabcbbcccb
            abcbaaaaccbaccccacbabbbaabaabbbcabababbcbaacaabbaabbcbaaabbbaaabcacacccbaaab
            ccbacacabaaaacbaacaacabcaaabbbcacabbbcbaccaacbbcbccbabbabcccbbbaccbbbaccacccbbbabcccaacaa
            acbbccccbacacbcaabbcbccbcccaaaabccaabcccbccbacbcaacc
            bbabbaccbbcabaccccaccbbcbabbabcbaaccbbcc
            bbcbacbacbabcacabbaaccbccacbcccbaccbbbcbacaaaacccaababcacbbcbbacabbccbbcbcbc
            accacbabaaacaaabbaaacacbcaccbacc
            cccabbbcbaaacaccaccabbacbabbcabcbaacbccbabccbbabacccbbcbbaccbccaacaaccbaabcbccacabcbcbcaaaaccccaccac
            ccbaccccbcccccbbccbaabaaabcabaabcbbcbccabccbcbacbcccbaccbabcabbcaa
            cccabccbcbbbabbcabcbaccbcbcabcaacaaccaacccbcaac
            cbabcacbbbcccaacbcbcabbcaaccbbcaaabcabcbacbaaccbbbabaabbaabbcacaaccaaccbcb
            cbcbaaacaabcbbaacaccbcccbabccacccbaabbacbbaabaaacbabaabbacccbbcbabccccbcbbcaaababbbcccbaabacaaaabcc
            cbabaabbaccbbaacbcacbabbbbbabacbccaacbcacbcbcbbaabcaabbbababccaccbcaacacbacbbaccaaaabcccb
            baccacaaabbbbcbbaacabcbcaccccacbbbbcbccbbaacbcbbbb
            abacbbcaaaacbabbbbcbcaccbcbaaaabbccabccccccccbacccacaccbbbcabbcbabbca
            babbabcaacabcbaccaaabcbaacaabbbcb
            bcabaabbcacaacbacc
            bbbabccccccabbaacbcabbcbbcbacabbcabbabbabbaaacaabba
            cbbaaaacbbabcaaaccbaacbbbcbcaaccbcabcbbbaaaaabbcacaabcb
            bbbcbcbcccbcbcbcaccabaababcbabaccccbbaaaaccccbbababcbcabcaaccbcbbbacababbcabcbb
            cabaaccaacccbabccbccbcacaabacabbbcbcabcaccaaabbabbacbbcccacaabbcbbbccbcbccacaccbaabbcabcbbc
            acccacbabacaaaabcaacbccaaabbaaba
            ccacababbbbcccbcabbaacbcacaccaccabbaacccaabcacacbcca
            aaaaacaacaabbbbbaacbcaccbbbabbbcbbabbbcccaabbaacb
            abbcbccccabbaabbccabccbbcacccaaacbabbabaaaabbba
            bbabbacaabbbcbbcbcbacacbaccaaabbcccacccbbacbcbbbbacbabccaccaabccacaacc
            bacaaabcccbbcaabaabbbcbbabcbbbbccaaabccbbbaccbaaaacbcbaaacc
            bbcbbabbacccbababcaccbbaacbbccbaaaacbbbcaacbbacaaaabcbbabacacababbabbbbccacbbbbccbaaacabacccaba
            abcbabbabbbaaaacbbacbabbabbbaaaabaacccabacaacbabcbaaca
            bbbcbbaca
            aacc
            bcabaaabbaacbccbbbababcacbb
            aaccbcbcccaaababcacacaccbcbcacaccccbcabbcccab
            caccaaaaacabbaababbccaaacabcbcbbcbaababcbbaaabcaa
            accbbbccbbbccbbbcacbcacbbacbbccccbbaababaccaabbbbbcbbcaaaabca
            ccabbacbacccaaacbbaaaaaaabaabacabcccabbacacabaccbababcabaccbabcbbbacaaacacccaa
            baacccbbaabcacccbbaabaabcabbabaacbcbbb
            cbccabbabcabcccbbccabccbcabcaaacccacbbacccbbbbcabcaaccccbbbbcbbcbcacbaabccabaccc
            aacacbbbaabbabccbcbbaccccbacbbcbbcbbbbabcbccc
            abcbbacaacbcccacbbcbcaaabccaacaabacabbacbcbbabacacaccbbbbabcaccccccbb
            bababbbcabccbbaccc
            bbcbbcbbc
            aababbc
            abbcabccccccbbbaabcbaccbabbbbbcbcacabbabacacbacbcaaaacbaccaaaccaabbcabacb
            bccbbccbcccabbabbbaacaaacabccacbacabbcabccb
            bcbcacbcabaaccaccabaabbbbaaaaccccababaa
            bbcbbabbaccabbacbaacacbcbaacbbaacacbabacaccbacbcaccbbbbcbbcaabbbbbcaaccbbbbaccaabc
            babbcababcccbbcbbaabcaccabcabcaccbbabcbacbaccaacacaaacabacccacbabaababbbcaaaabcbbabcccaaabaabca
            acccaaababcbabaacaabaccaaabbaccbbbacabbbcabbcbcbccabbab
            aaabaaaccacccbaccbbcbabbacccacbbacaacbacbcbbbccbbaaccccabbcbabaaabbbcbabccaaca
            bbccacbababbbcccbaccaacbaccbccacbbbcaabcacacbcac
            ccaaaabcccaaaccbbccbacbcaccaccbbaabaacaacbbaaacbbcabbccbbccacbccbaccabcaccabaaabababbaaacbbbaabc
            bbb
            bccaaacbaabcacaabaaabcabbcacbbaabcccababbcbacbbbacbbcbbabbcaaccccbbaacccbbccacaabcabbcbbabcbcb
            bacabaabbbbbcacbcccabbcccbaaacccacaccaacccaaaabacabbbbbaabbabaacbbbacca
            cbac
            bacccaabbbbacccbabcccacccabbacabccbcabacacaabababbcbacbccabacbcabacbcbbca
            aaccbbcaaabcabcbcacbabcabbbacaacbacccbcccbbcabaacbbacbbbaacabaacacbcccbbaabbabbc
            abaccbaabacbaccabbaa
            bbccaacbaccbccbcccaaccaccbbabbcacaaaaacbaccabbaccccbbabbaccb
            ccbabbabbccbcbacccbbcaabcbbbbcab
            cbbbbaabbcbccbbacbcabacabcbcccccbbacbbccabcbccbcabcccccbcbbcbbbccbacaccbaacccabaabccbaba
            bcacbaabaaccaaaabcacbacbbccbbaacabcaccbaaabbbbbccacbbbccbc
            aacabaabcbaabbccaacaccacbcbbbbacbcabaacabbbacaaaccbccbbcbabacbccbcacbaacbcababbcbacccabbbcccabb
            cbbaba
            bcbacccaaaccaabbaabccbbbacbbbbbabcabcacaababaaabacbaacabcbc
            abbcbcbacbbaaabaaacbcaccacacbaacbccabaccbbacbaacaaccbbccbacaacacccacccccbcbbccaaaca
            bccacbaacaacabcabbcccbacacabcabcabcaabccccaabcbcbb
            acacaaaccbbccacabbcbabbacbcca
            cbaabcacbabbaabaaabbcbcbaaacaaaccaabcbbcc
            babaabbbabaacabaacbaabbaaccccccbcabccababbbbcabaccbcbcbbcabccaacacbacabbbcaaccabcccbcaa
            accacccbcbccbabaccccbabaaaccaacbabccbcbbaaaca
            aabcccabbabaaaaacabcbabccabacbbaacacabbbbb
            cbacabbaaacbaccacbbbbcbccaabcbacaaccaacabccbcbccabbcacbababbccabacaaaacaabbcaacbaaaabaccaa
            ccbaabbbccacaabaacbccbabaaacababcbcacbbcbabcaccbaaacabbaccbabbcaacaabcacaccac
            ccaaaaccbbcccbccbabcaacbcabcbbabbbcccbbcabbacbabbbbabbcbcaab
            baabaaaccaaacbbbbcaabbcaababcbabcbcccbcbbcabbbaabbacaaaabacaccccbbcbabaccbbacbccaccababcbaab
            aaacabacaabbbccbbbccbaabbcaaacbbacbaccaccbbbcbaaaaccbaaaab
            bbcacccabbbbbacaabbbbcbaaccbabacacacccbbacabababacacbcaccaaacaaabacbabbbbbbcab
            aababbbbbbcbaabacabbbaccccacccaaccbbaccbaabbbaaaaccbcccccabcabacbbcaacbbca
            abbbbbbbbbabaaccacbbacaaaaabaacacbababaccaba
            aaaabccbaacabaacbcbacabbabbbcbbabbcbababbcbaaaacacaabcbcbcbbbccabbbccbacbcaccbbcb
            a
            bbccbbbcbbbcccbaccaabaaccccabaabcabccacabaaabcaabababccabccaacbcaabcbbacbacacbaacabccbaba
            cacbaccccabcaaaabcbcacccbbbcabcacbcaccababcaaabcaabbabbcacbcbaabccccccbc",
            Expected = @"
                        1
                        2
                        1
                        1
                        2
                        2
                        2
                        1
                        1
                        1
                        1
                        1
                        2
                        2
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        2
                        1
                        2
                        1
                        1
                        1
                        1
                        2
                        1
                        1
                        1
                        2
                        1
                        1
                        1
                        1
                        1
                        1
                        2
                        1
                        1
                        2
                        1
                        2
                        1
                        1
                        1
                        1
                        2
                        1
                        1
                        1
                        1
                        2
                        1
                        2
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        3
                        1
                        1
                        1
                        1
                        2
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        2
                        1
                        2
                        2
                        2
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        1
                        2
                        1
                        1
                        2"
        };
    }
}