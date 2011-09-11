using System;
using System.Linq;
using System.Linq.Expressions;

namespace IntroToExpressions
{
	public static class Validate
	{
		public static void IsNotNull<T>(Expression<Func<T>> expr)
		{
			MemberExpression memExpr = getMemberExpression(expr);

			var value = extractMemberValue(memExpr);

			if (value != null)
				return;

			throw new ArgumentNullException(memExpr.Member.Name);
		}

		private static MemberExpression getMemberExpression<T>(Expression<Func<T>> expr)
		{
			var visitor = new CustomExpressionVisitor();
			visitor.Visit(expr);
			MemberExpression memExpr = visitor.Expressions.Last().Value as MemberExpression;

			if (memExpr == null)
				throw new ArgumentException("Expected a MemberExpression");

			return memExpr;
		}

		private static object extractMemberValue(MemberExpression memExpr)
		{
			var func = Expression.Lambda(memExpr).Compile();
			var value = func.DynamicInvoke();
			return value;
		}

		[Obsolete("Use the overload which accepts an Expression")]
		public static void IsNotNull(object o, string parameterName)
		{
			if (o != null)
				return;

			throw new ArgumentNullException(parameterName);
		}
	}
}
