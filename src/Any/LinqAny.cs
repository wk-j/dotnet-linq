using System;
using System.Collections.Generic;

namespace Anyyy {
    public static class LinqAny {
        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) {
            if (source == null) {
                // ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
            }

            if (predicate == null) {
                // ThrowHelper.ThrowArgumentNullException(ExceptionArgument.predicate);
            }

            foreach (TSource element in source) {
                if (predicate(element)) {
                    return true;
                }
            }

            return false;
        }
    }
}
