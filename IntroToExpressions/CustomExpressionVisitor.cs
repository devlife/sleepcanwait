using System.Collections.Generic;
using System.Linq.Expressions;

namespace IntroToExpressions
{
	/// <summary>
	/// Extracts all MemberExpressions from an Expression tree.
	/// </summary>
	public class CustomExpressionVisitor : ExpressionVisitor
	{
		private	int currentIndex = 0;
		public SortedList<int, Expression> Expressions { get; private set; }

		public override Expression Visit(Expression node)
		{
			currentIndex = 0;
			Expressions = new SortedList<int, Expression>();

			return base.Visit(node);
		}

		protected override Expression VisitMember(MemberExpression node)
		{
			Expressions.Add(currentIndex++, node);
			return base.VisitMember(node);
		}
	}
}
