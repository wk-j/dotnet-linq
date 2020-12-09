using System;
using System.Collections.Generic;

namespace Anyyy {
    public static class LinqExept {
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second) {
            if (first == null) {
                // ThrowHelper.ThrowArgumentNullException(ExceptionArgument.first);
            }

            if (second == null) {
                // ThrowHelper.ThrowArgumentNullException(ExceptionArgument.second);
            }

            return ExceptIterator(first, second, null);
        }

        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer) {
            if (first == null) {
                // ThrowHelper.ThrowArgumentNullException(ExceptionArgument.first);
            }

            if (second == null) {
                // ThrowHelper.ThrowArgumentNullException(ExceptionArgument.second);
            }

            return ExceptIterator(first, second, comparer);
        }

        private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer) {
            // Set<TSource> set = new Set<TSource>(comparer);
            // set.UnionWith(second);

            // foreach (TSource element in first) {
            //     if (set.Add(element)) {
            //         yield return element;
            //     }
            // }

            yield return default;
        }
    }
}
