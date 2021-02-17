using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace FileProcessing.Business
{
    public class ExceptionHandler
    {
        public int NegativeExceptionCodeHandler(Exception e) //Handles exceptions. Will return exceptions with 1 in the start for SystemExceptions. Exceptions with the start of 2 will 
        {                                                                          //returns data exceptions and the ones that start with 3 is input output excpetions. 000 = Unknown error
            if (e.GetType() == typeof(SystemException)) return 100; //100 is system exceptions
            if (e.GetType() == typeof(AccessViolationException)) return 101; 
            if (e.GetType() == typeof(AggregateException)) return 102;
            if (e.GetType() == typeof(AppDomainUnloadedException)) return 103;
            if (e.GetType() == typeof(ApplicationException)) return 105;
            if (e.GetType() == typeof(ArgumentException)) return 106;
            if (e.GetType() == typeof(ArgumentNullException)) return 107;
            if (e.GetType() == typeof(ArgumentOutOfRangeException)) return 108;
            if (e.GetType() == typeof(ArithmeticException)) return 109;
            if (e.GetType() == typeof(ArrayTypeMismatchException)) return 110;
            if (e.GetType() == typeof(BadImageFormatException)) return 111;
            if (e.GetType() == typeof(CannotUnloadAppDomainException)) return 112;
            if (e.GetType() == typeof(ContextMarshalException)) return 113;
            if (e.GetType() == typeof(DataMisalignedException)) return 114;
            if (e.GetType() == typeof(DivideByZeroException)) return 115;
            if (e.GetType() == typeof(DllNotFoundException)) return 116;
            if (e.GetType() == typeof(DuplicateWaitObjectException)) return 117;
            if (e.GetType() == typeof(EntryPointNotFoundException)) return 118;
            if (e.GetType() == typeof(UnauthorizedAccessException)) return 119;
            if (e.GetType() == typeof(FieldAccessException)) return 120;
            if (e.GetType() == typeof(FormatException)) return 121;
            if (e.GetType() == typeof(IndexOutOfRangeException)) return 122;
            if (e.GetType() == typeof(InsufficientMemoryException)) return 123;
            if (e.GetType() == typeof(InvalidCastException)) return 124;
            if (e.GetType() == typeof(InvalidOperationException)) return 125;
            if (e.GetType() == typeof(InvalidProgramException)) return 126;
            if (e.GetType() == typeof(InvalidTimeZoneException)) return 127;
            if (e.GetType() == typeof(MemberAccessException)) return 128;
            if (e.GetType() == typeof(MethodAccessException)) return 129;
            if (e.GetType() == typeof(MissingFieldException)) return 130;
            if (e.GetType() == typeof(MissingMemberException)) return 131;
            if (e.GetType() == typeof(MissingMethodException)) return 132;
            if (e.GetType() == typeof(MulticastNotSupportedException)) return 133;
            if (e.GetType() == typeof(UriFormatException)) return 134;
            if (e.GetType() == typeof(NotFiniteNumberException)) return 135;
            if (e.GetType() == typeof(NotImplementedException)) return 136;
            if (e.GetType() == typeof(NotSupportedException)) return 137;
            if (e.GetType() == typeof(NullReferenceException)) return 138;
            if (e.GetType() == typeof(ObjectDisposedException)) return 139;
            if (e.GetType() == typeof(OperationCanceledException)) return 140;
            if (e.GetType() == typeof(OutOfMemoryException)) return 141;
            if (e.GetType() == typeof(OverflowException)) return 142;
            if (e.GetType() == typeof(PlatformNotSupportedException)) return 143;
            if (e.GetType() == typeof(RankException)) return 144;
            if (e.GetType() == typeof(StackOverflowException)) return 145;
            if (e.GetType() == typeof(UriFormatException)) return 146;
            if (e.GetType() == typeof(TimeoutException)) return 147;
            if (e.GetType() == typeof(TimeZoneNotFoundException)) return 148;
            if (e.GetType() == typeof(TypeAccessException)) return 149;
            if (e.GetType() == typeof(TypeInitializationException)) return 150;
            if (e.GetType() == typeof(TypeLoadException)) return 151;
            if (e.GetType() == typeof(TypeUnloadedException)) return 152;

            if (e.GetType() == typeof(DataException)) return 200;
            if (e.GetType() == typeof(ConstraintException)) return 201;
            if (e.GetType() == typeof(DBConcurrencyException)) return 202;
            if (e.GetType() == typeof(DuplicateNameException)) return 203;
            if (e.GetType() == typeof(EvaluateException)) return 204;
            if (e.GetType() == typeof(InRowChangingEventException)) return 205;
            if (e.GetType() == typeof(InvalidConstraintException)) return 206;
            if (e.GetType() == typeof(InvalidExpressionException)) return 207;
            if (e.GetType() == typeof(MissingPrimaryKeyException)) return 208;
            if (e.GetType() == typeof(NoNullAllowedException)) return 209;
            if (e.GetType() == typeof(ReadOnlyException)) return 210;
            if (e.GetType() == typeof(RowNotInTableException)) return 211;
            if (e.GetType() == typeof(StrongTypingException)) return 212;
            if (e.GetType() == typeof(SyntaxErrorException)) return 213;
            if (e.GetType() == typeof(VersionNotFoundException)) return 214;

            if (e.GetType() == typeof(IOException)) return 300;
            if (e.GetType() == typeof(DirectoryNotFoundException)) return 301;
            if (e.GetType() == typeof(DriveNotFoundException)) return 302;
            if (e.GetType() == typeof(EndOfStreamException)) return 303;
            if (e.GetType() == typeof(FileLoadException)) return 304;
            if (e.GetType() == typeof(FileNotFoundException)) return 305;
            if (e.GetType() == typeof(InternalBufferOverflowException)) return 306;
            if (e.GetType() == typeof(InvalidDataException)) return 307;
            if (e.GetType() == typeof(PathTooLongException)) return 308;
            return 000; // 000 means unknown error
        }
    }
}
