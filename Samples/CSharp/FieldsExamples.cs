// <copyright file="FieldsExamples.cs" company="PROJECT-AUTHOR">
// © PROJECT-AUTHOR
// </copyright>

namespace CSharpSamples
{
    internal class FieldsExamples
    {
        // StyleCop requires members in the following order: Public, Internal, Protected Internal, Protected, Private
        // See: https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1202.md
        #region // `Public` fields
        /*
         * StyleCop explicitly prohibits any non-private fields, resulting in essentially four rules:
         * (1) const fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1303.md ConstFieldNamesMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1307.md AccessibleFieldsMustBeginWithUpperCaseLetter
         * (2) static readonly fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1311.md StaticReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1304.md NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1307.md AccessibleFieldsMustBeginWithUpperCaseLetter
         * (3) other private fields must be camelCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1306.md FieldNamesMustBeginWithLowerCaseLetter
         * (4) all other fields are explicitly prohibited
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1401.md FieldsMustBePrivate
         *
         * The .NET Framework [Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/index)
         * also explicitly prohibit publicly-exposed fields (thus applies to accesibility modifier `public`),
         * with only two exceptions to the prohibition:
         * (1) const fields
         * (2) static readonly fields
         * And requires those fields to be PascalCase.
         * See https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/field
         * Therefore, the .NET Guidelines for `public` fields are compatible with StyleCop.
         */

        // Allowed by both .NET Guidelines and StyleCop, and are properly PascalCased
        public        const    int PascalCasePublicConstField          = 1;
        public static readonly int PascalCasePublicStaticReadonlyField = 1;

        // Allowed by both .NET Guidelines and StyleCop, but should generate a warning due to use of camelCase
        public        const    int camelCasePublicConstField           = 1;
        public static readonly int camelCasePublicStaticReadonlyField  = 1;

        // Prohibited by both .NET Guidelines and StyleCop (other publicly-exposed fields)
        public static          int PascalCasePublicStaticField         = 1;
        public static          int camelCasePublicStaticField          = 1;
        public        readonly int PascalCasePublicReadonlyField       = 1;
        public        readonly int camelCasePublicReadonlyField        = 1;
        public                 int PascalCasePublicField               = 1;
        public                 int camelCasePublicField                = 1;
        #endregion // `Public` fields
        #region // `Internal` fields
        /*
         * StyleCop explicitly prohibits any non-private fields, resulting in essentially four rules:
         * (1) const fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1303.md ConstFieldNamesMustBeginWithUpperCaseLetter
         * (2) static readonly fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1311.md StaticReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1304.md NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter
         * (3) other private fields must be camelCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1306.md FieldNamesMustBeginWithLowerCaseLetter
         * (4) all other fields are explicitly prohibited
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1401.md FieldsMustBePrivate
         *
         * The .NET Framework [Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/index)
         * only apply to publicly-exposed fields.  Therefore, because fields with an accesibility modifier of `internal`
         * are only accessible within the containing assembly, they are outside the scope of the .NET guidelines.
         */

        // Allowed by both .NET Guidelines and StyleCop, and are properly PascalCased
        internal        const    int PascalCaseInternalConstField          = 1;
        internal static readonly int PascalCaseInternalStaticReadonlyField = 1;

        // Allowed by both .NET Guidelines and StyleCop, but should generate a warning due to use of camelCase
        internal        const    int camelCaseInternalConstField           = 1;
        internal static readonly int camelCaseInternalStaticReadonlyField  = 1;

        // Prohibited by both .NET Guidelines and StyleCop (other publicly-exposed fields)
        internal static          int PascalCaseInternalStaticField   = 1;
        internal static          int camelCaseInternalStaticField    = 1;
        internal        readonly int PascalCaseInternalReadonlyField = 1;
        internal        readonly int camelCaseInternalReadonlyField  = 1;
        internal                 int PascalCaseInternalField         = 1;
        internal                 int camelCaseInternalField          = 1;
        #endregion // `Internal` fields
        #region // `Protected Internal` fields
        /*
         * StyleCop explicitly prohibits any non-private fields, resulting in essentially four rules:
         * (1) const fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1303.md ConstFieldNamesMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1307.md AccessibleFieldsMustBeginWithUpperCaseLetter
         * (2) static readonly fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1311.md StaticReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1304.md NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1307.md AccessibleFieldsMustBeginWithUpperCaseLetter
         * (3) other private fields must be camelCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1306.md FieldNamesMustBeginWithLowerCaseLetter
         * (4) all other fields are explicitly prohibited
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1401.md FieldsMustBePrivate
         *
         * The .NET Framework [Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/index)
         * also explicitly prohibit publicly-exposed fields (thus applies to accesibility modifier `protected internal`),
         * with only two exceptions to the prohibition:
         * (1) const fields
         * (2) static readonly fields
         * And requires those fields to be PascalCase.
         * See https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/field
         * Therefore, the .NET Guidelines for `public` fields are compatible with StyleCop.
         */

        // Allowed by both .NET Guidelines and StyleCop, and are properly PascalCased
        protected internal        const    int PascalCaseProtectedInternalConstField          = 1;
        protected internal static readonly int PascalCaseProtectedInternalStaticReadonlyField = 1;

        // Allowed by both .NET Guidelines and StyleCop, but should generate a warning due to use of camelCase
        protected internal        const    int camelCaseProtectedInternalConstField           = 1;
        protected internal static readonly int camelCaseProtectedInternalStaticReadonlyField  = 1;

        // Prohibited by both .NET Guidelines and StyleCop (other publicly-exposed fields)
        protected internal static          int PascalCaseProtectedInternalStaticStaticField   = 1;
        protected internal static          int camelCaseProtectedInternalStaticField          = 1;
        protected internal        readonly int PascalCaseProtectedInternalReadonlyField       = 1;
        protected internal        readonly int camelCaseProtectedInternalReadonlyField        = 1;
        protected internal                 int PascalCaseProtectedInternalField               = 1;
        protected internal                 int camelCaseProtectedInternalField                = 1;
        #endregion // `Protected Internal` fields
        #region // `Protected` fields
        /*
         * StyleCop explicitly prohibits any non-private fields, resulting in essentially four rules:
         * (1) const fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1303.md ConstFieldNamesMustBeginWithUpperCaseLetter
         * (2) static readonly fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1311.md StaticReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1304.md NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter
         * (3) other private fields must be camelCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1306.md FieldNamesMustBeginWithLowerCaseLetter
         * (4) all other fields are explicitly prohibited
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1401.md FieldsMustBePrivate
         *
         * The .NET Framework [Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/index)
         * also explicitly prohibit publicly-exposed fields (thus applies to accesibility modifier `protected`),
         * with only two exceptions to the prohibition:
         * (1) const fields
         * (2) static readonly fields
         * And requires those fields to be PascalCase.
         * See https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/field
         * Therefore, the .NET Guidelines for `public` fields are compatible with StyleCop.
         */

        // Allowed by both .NET Guidelines and StyleCop, and are properly PascalCased
        protected        const    int PascalCaseProtectedConstField          = 1;
        protected static readonly int PascalCaseProtectedStaticReadonlyField = 1;

        // Allowed by both .NET Guidelines and StyleCop, but should generate a warning due to use of camelCase
        protected        const    int camelCaseProtectedConstField           = 1;
        protected static readonly int camelCaseProtectedStaticReadonlyField  = 1;

        // Prohibited by both .NET Guidelines and StyleCop (other publicly-exposed fields)
        protected static          int PascalCaseProtectedStaticField         = 1;
        protected static          int camelCaseProtectedStaticField          = 1;
        protected        readonly int PascalCaseProtectedReadonlyField       = 1;
        protected        readonly int camelCaseProtectedReadonlyField        = 1;
        protected                 int PascalCaseProtectedField               = 1;
        protected                 int camelCaseProtectedField                = 1;
        #endregion // `Protected` fields
        #region // `Private Protected` fields
        /*
         * StyleCop explicitly prohibits any non-private fields, resulting in essentially four rules:
         * (1) const fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1303.md ConstFieldNamesMustBeginWithUpperCaseLetter
         * (2) static readonly fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1311.md StaticReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1304.md NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter
         * (3) other private fields must be camelCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1306.md FieldNamesMustBeginWithLowerCaseLetter
         * (4) all other fields are explicitly prohibited
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1401.md FieldsMustBePrivate
         *
         * The .NET Framework [Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/index)
         * only apply to publicly-exposed fields.  Therefore, because fields with an accesibility modifier of `private protected`
         * are only accessible within the containing assembly, they are outside the scope of the .NET guidelines.
         */

        // Allowed by StyleCop, and are properly PascalCased (.NET guidelines silent on fields that are not publicly exposed)
        private protected        const    int PascalCasePrivateProtectedConstField          = 1;
        private protected static readonly int PascalCasePrivateProtectedStaticReadonlyField = 1;

        // Allowed by StyleCop, and are properly camelCased (.NET guidelines silent on fields that are not publicly exposed)
        private protected        const    int camelCasePrivateProtectedConstField           = 1;
        private protected static readonly int camelCasePrivateProtectedStaticReadonlyField  = 1;

        // Prohibited StyleCop (other publicly-exposed fields)
        private protected static          int PascalCasePrivateProtectedStaticField         = 1;
        private protected static          int camelCasePrivateProtectedStaticField          = 1;
        private protected        readonly int PascalCasePrivateProtectedReadonlyField       = 1;
        private protected        readonly int camelCasePrivateProtectedReadonlyField        = 1;
        private protected                 int PascalCasePrivateProtectedField               = 1;
        private protected                 int camelCasePrivateProtectedField                = 1;
        #endregion // `Private Protected` fields
        #region // `Private` fields
        /*
         * StyleCop allows private fields.  The rules for `const` and `static readonly` still take precedence:
         * (1) const fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1303.md ConstFieldNamesMustBeginWithUpperCaseLetter
         * (2) static readonly fields must be PascalCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1311.md StaticReadonlyFieldsMustBeginWithUpperCaseLetter
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1304.md NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter
         * (3) other private fields must be camelCase
         *     See https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1306.md FieldNamesMustBeginWithLowerCaseLetter
         *
         * The .NET Framework [Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/index)
         * only apply to publicly-exposed fields.  Therefore, because fields with an accesibility modifier of `private`
         * are only accessible within the containing class, they are outside the scope of the .NET guidelines.
         */

        // Allowed by StyleCop, and are properly PascalCased (.NET guidelines silent on fields that are not publicly exposed)
        private        const    int PascalCasePrivateConstField          = 1;
        private static readonly int PascalCasePrivateStaticReadonlyField = 1;

        // Allowed by StyleCop, and are properly camelCased (.NET guidelines silent on fields that are not publicly exposed)
        private static          int camelCasePrivateStaticField          = 1;
        private        readonly int camelCasePrivateReadonlyField        = 1;
        private                 int camelCasePrivateField                = 1;

        // Allowed by StyleCop, but should generate a warning due to use of camelCase
        private        const    int camelCasePrivateConstField           = 1;
        private static readonly int camelCasePrivateStaticReadonlyField  = 1;

        // Allowed by StyleCop, but should generate a warning due to use of PascalCase
        private static          int PascalCasePrivateStaticField         = 1;
        private        readonly int PascalCasePrivateReadonlyField       = 1;
        private                 int PascalCasePrivateField               = 1;
        #endregion // `Private` fields

        private void Foo() // To get around warnings telling you fields must be readonly.
        {
            // prevent IDE0044 "Make field readonly"
            camelCasePrivateStaticField = 1;
            this.camelCasePrivateField = 1;
            PascalCasePrivateStaticField = 1;
            this.PascalCasePrivateField = 1;
        }
    }
}
