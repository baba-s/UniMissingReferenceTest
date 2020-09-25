using NUnit.Framework;

namespace Kogane.Internal
{
	internal sealed class MissingReferenceTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void Missing_Reference_が存在しない()
		{
			AllGameObjectTester.Test( gameObject => !MissingReferenceUtils.HasMissingReference( gameObject ) );
		}
	}
}