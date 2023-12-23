namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    internal sealed class CallerArgumentExpressionAttribute : Attribute
    {
        public CallerArgumentExpressionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; }
    }
}

namespace Cti.Stix.Internal
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines static methods used to throw exceptions.
    /// </summary>
    internal static class Throws
    {
        /// <summary>
        /// Throws an System.ArgumentNullException if the specified argument is null.
        /// </summary>
        /// <typeparam name="T">Argument type to be checked for null.</typeparam>
        /// <param name="argument">Object to be checked for null.</param>
        /// <param name="paramName">The name of the parameter being checked.</param>
        /// <returns>The original value of argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NotNull]
        public static T IfNull<T>([NotNull] T argument, [CallerArgumentExpression("argument")] string paramName = "")
        {
            if (argument == null)
            {
                ArgumentNullException(paramName);
            }

            return argument;
        }

        /// <summary>
        /// Throws an System.ArgumentNullException if the specified argument is null, or
        /// System.ArgumentException if the specified member is null.
        /// </summary>
        /// <typeparam name="TParameter">Argument type to be checked for null.</typeparam>
        /// <typeparam name="TMember">Member type to be checked for null.</typeparam>
        /// <param name="argument">Argument to be checked for null.</param>
        /// <param name="member">Object member to be checked for null.</param>
        /// <param name="paramName">The name of the parameter being checked.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The original value of member.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NotNull]
        public static TMember IfNullOrMemberNull<TParameter, TMember>([NotNull] TParameter argument, [NotNull] TMember member, [CallerArgumentExpression("argument")] string paramName = "", [CallerArgumentExpression("member")] string memberName = "")
        {
            if (argument == null)
            {
                ArgumentNullException(paramName);
            }

            if (member == null)
            {
                //DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
                //defaultInterpolatedStringHandler.AppendLiteral("Member ");
                //defaultInterpolatedStringHandler.AppendFormatted(memberName);
                //defaultInterpolatedStringHandler.AppendLiteral(" of ");
                //defaultInterpolatedStringHandler.AppendFormatted(paramName);
                //defaultInterpolatedStringHandler.AppendLiteral(" is null");
                ArgumentException(paramName, "");
            }

            return member;
        }

        /// <summary>
        /// Throws an System.ArgumentException if the specified member is null.
        /// </summary>
        /// <typeparam name="TParameter">Argument type.</typeparam>
        /// <typeparam name="TMember">Member type to be checked for null.</typeparam>
        /// <param name="argument">Argument to which member belongs.</param>
        /// <param name="member">Object member to be checked for null.</param>
        /// <param name="paramName">The name of the parameter being checked.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The original value of member.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NotNull]
        public static TMember IfMemberNull<TParameter, TMember>(TParameter argument, [NotNull] TMember member, [CallerArgumentExpression("argument")] string paramName = "", [CallerArgumentExpression("member")] string memberName = "") where TParameter : notnull
        {
            if (member == null)
            {
                //DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
                //defaultInterpolatedStringHandler.AppendLiteral("Member ");
                //defaultInterpolatedStringHandler.AppendFormatted(memberName);
                //defaultInterpolatedStringHandler.AppendLiteral(" of ");
                //defaultInterpolatedStringHandler.AppendFormatted(paramName);
                //defaultInterpolatedStringHandler.AppendLiteral(" is null");
                ArgumentException(paramName, "");
            }

            return member;
        }

        /// <summary>
        /// Throws either an System.ArgumentNullException or an System.ArgumentException
        /// if the specified string is null or whitespace respectively.
        /// </summary>
        /// <param name="argument">String to be checked for null or whitespace.</param>
        /// <param name="paramName">The name of the parameter being checked.</param>
        /// <returns>The original value of argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NotNull]
        public static string IfNullOrWhitespace([NotNull] string? argument, [CallerArgumentExpression("argument")] string paramName = "")
        {
            if (string.IsNullOrWhiteSpace(argument))
            {
                if (argument == null)
                {
                    ArgumentNullException(paramName);
                }
                else
                {
                    ArgumentException(paramName, "Argument is whitespace");
                }
            }

            return argument;
        }

        /// <summary>
        /// Throws an System.ArgumentNullException if the string is null, or System.ArgumentException if it is empty.
        /// </summary>
        /// <param name="argument">String to be checked for null or empty.</param>
        /// <param name="paramName">The name of the parameter being checked.</param>
        /// <returns>The original value of argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NotNull]
        public static string IfNullOrEmpty([NotNull] string? argument, [CallerArgumentExpression("argument")] string paramName = "")
        {
            if (string.IsNullOrEmpty(argument))
            {
                if (argument == null)
                {
                    ArgumentNullException(paramName);
                }
                else
                {
                    ArgumentException(paramName, "Argument is an empty string");
                }
            }

            return argument;
        }

        /// <summary>
        /// Throws an System.ArgumentException if the argument's buffer size is less than the required buffer size.
        /// </summary>
        /// <param name="bufferSize">The actual buffer size.</param>
        /// <param name="requiredSize">The required buffer size.</param>
        /// <param name="paramName">The name of the parameter to be checked.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IfBufferTooSmall(int bufferSize, int requiredSize, string paramName = "")
        {
            if (bufferSize < requiredSize)
            {
                //DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
                //defaultInterpolatedStringHandler.AppendLiteral("Buffer too small, needed a size of ");
                //defaultInterpolatedStringHandler.AppendFormatted(requiredSize);
                //defaultInterpolatedStringHandler.AppendLiteral(" but got ");
                //defaultInterpolatedStringHandler.AppendFormatted(bufferSize);
                ArgumentException(paramName, "");
            }
        }

        /// <summary>
        /// Throws an System.ArgumentOutOfRangeException if the enum value is not valid.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="argument">The argument to evaluate.</param>
        /// <param name="paramName"></param>
        /// <returns>The original value of argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T IfOutOfRange<T>(T argument, [CallerArgumentExpression("argument")] string paramName = "") where T : struct, Enum
        {
            if (!Enum.IsDefined(argument.GetType(), argument))
            {
                //DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
                //defaultInterpolatedStringHandler.AppendFormatted(argument);
                //defaultInterpolatedStringHandler.AppendLiteral(" is an invalid value for enum type ");
                //defaultInterpolatedStringHandler.AppendFormatted(typeof(T));
                ArgumentOutOfRangeException(paramName);
            }

            return argument;
        }

        /// <summary>
        /// Throws an System.ArgumentNullException if the collection is null, or System.ArgumentException if it is empty.
        /// </summary>
        /// <typeparam name="T">The type of objects in the collection.</typeparam>
        /// <param name="argument">The collection to evaluate.</param>
        /// <param name="paramName">The name of the parameter being checked.</param>
        /// <returns>The original value of argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NotNull]
        public static ICollection<T> IfNullOrEmpty<T>([NotNull] ICollection<T>? argument, [CallerArgumentExpression("argument")] string paramName = "")
        {
            if (argument == null)
            {
                ArgumentNullException(paramName);
            }
            else if (argument!.Count == 0)
            {
                ArgumentException(paramName, "Collection is empty");
            }

            return argument;
        }

        /// <summary>
        /// Throws an System.ArgumentNullException if the collection is null, or System.ArgumentException if it is empty.
        /// </summary>
        /// <typeparam name="T">The type of objects in the collection.</typeparam>
        /// <param name="argument">The collection to evaluate.</param>
        /// <param name="paramName">The name of the parameter being checked.</param>
        /// <returns>The original value of argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NotNull]
        public static IReadOnlyCollection<T> IfNullOrEmpty<T>([NotNull] IReadOnlyCollection<T>? argument, [CallerArgumentExpression("argument")] string paramName = "")
        {
            if (argument == null)
            {
                ArgumentNullException(paramName);
            }
            else if (argument!.Count == 0)
            {
                ArgumentException(paramName, "Collection is empty");
            }

            return argument;
        }

        /// <summary>
        /// Throws an System.ArgumentNullException.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentNullException(string paramName)
        {
            throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Throws an System.ArgumentNullException.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentNullException(string paramName, string? message)
        {
            throw new ArgumentNullException(paramName, message);
        }

        /// <summary>
        /// Throws an System.ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentOutOfRangeException(string paramName)
        {
            throw new ArgumentOutOfRangeException(paramName);
        }


        /// <summary>
        /// Throws an System.ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentOutOfRangeException(string paramName, string? message)
        {
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        /// <summary>
        /// Throws an System.ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="actualValue">The value of the argument that caused this exception.</param>
        /// <param name="message">A message that describes the error.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentOutOfRangeException(string paramName, object? actualValue, string? message)
        {
            throw new ArgumentOutOfRangeException(paramName, actualValue, message);
        }

        /// <summary>
        /// Throws an System.ArgumentException.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        /// <exception cref="ArgumentException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentException(string paramName, string? message)
        {
            throw new ArgumentException(message, paramName);
        }

        /// <summary>
        /// Throws an System.ArgumentException.
        /// If the innerException is not a null, the current exception is raised in a catch block that handles the inner exception.
        /// </summary>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// <param name="message">A message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        /// <exception cref="ArgumentException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void ArgumentException(string paramName, string? message, Exception? innerException)
        {
            throw new ArgumentException(message, paramName, innerException);
        }

        /// <summary>
        ///  an System.InvalidOperationException.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        /// <exception cref="InvalidOperationException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void InvalidOperationException(string message)
        {
            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Throws an System.InvalidOperationException.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        /// <exception cref="InvalidOperationException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [DoesNotReturn]
        public static void InvalidOperationException(string message, Exception? innerException)
        {
            throw new InvalidOperationException(message, innerException);
        }
    }
}
