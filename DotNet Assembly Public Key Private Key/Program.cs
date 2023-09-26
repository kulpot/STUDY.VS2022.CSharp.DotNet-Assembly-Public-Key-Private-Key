using System;
using System.Reflection;

//ref link:https://www.youtube.com/watch?v=zKORh5eM6ZI&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=16
//  .Net Assembly Signing - means public key authentication approval
// Private Key - encryption algorithm
// Public Key - encryption algorithm


//[assembly: AssemblyVersion("1.0.0.0")]         // requires knowledge in attributes/reflections
[assembly: AssemblyVersion("2.0.0.0")]
//----4 Assembly IDENTIFYER---
// 1- Name
// 2- Version
// 3- Public Key    
// 4- Culture

// csc /out:Farm.dll    -- basic name

/*-------------------------CMD---------------------------------------------
 * 
 * 
-------------------------created----------
using System;
using System.Reflection;

[assembly: AssemblyVersion("1.0.0.0")]          

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Moo Version 1");
    }
}

------------------------------------------

C:\Users\sunny\source\repos\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version

26/09/2023  05:16 am    <DIR>          .
26/09/2023  05:16 am    <DIR>          ..
26/09/2023  05:16 am             2,581 .gitattributes
26/09/2023  05:16 am             6,585 .gitignore
26/09/2023  05:20 am    <DIR>          DotNet Assembly Version
26/09/2023  05:10 am             1,175 DotNet Assembly Version.sln
               3 File(s)         10,341 bytes
               3 Dir(s)  489,139,912,704 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Version>cd DotNet Assembly Version

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version

26/09/2023  05:20 am    <DIR>          .
26/09/2023  05:20 am    <DIR>          ..
26/09/2023  05:09 am               189 App.config
26/09/2023  05:09 am    <DIR>          bin
26/09/2023  05:10 am             2,396 DotNet Assembly Version.csproj
26/09/2023  05:09 am    <DIR>          obj
26/09/2023  05:20 am               592 Program.cs
26/09/2023  05:19 am    <DIR>          Properties
               3 File(s)          3,177 bytes
               5 Dir(s)  489,139,908,608 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version

26/09/2023  05:23 am    <DIR>          .
26/09/2023  05:23 am    <DIR>          ..
26/09/2023  05:09 am               189 App.config
26/09/2023  05:09 am    <DIR>          bin
26/09/2023  05:10 am             2,396 DotNet Assembly Version.csproj
26/09/2023  05:23 am             3,584 Farm.dll
26/09/2023  05:09 am    <DIR>          obj
26/09/2023  05:21 am             2,040 Program.cs
26/09/2023  05:19 am    <DIR>          Properties
               4 File(s)          8,209 bytes
               5 Dir(s)  489,139,191,808 bytes free
----------------------
turn all lines to comment then.....
---------------------------------created---

using System;

class MeMainClass
{
    static void Main()
    {
        Cow.Moo();
    }
}

----------------------------------
C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>csc /r:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version

26/09/2023  05:29 am    <DIR>          .
26/09/2023  05:29 am    <DIR>          ..
26/09/2023  05:09 am               189 App.config
26/09/2023  05:09 am    <DIR>          bin
26/09/2023  05:23 am             2,411 DotNet Assembly Version.csproj
26/09/2023  05:23 am             3,584 Farm.dll
26/09/2023  05:09 am    <DIR>          obj
26/09/2023  05:29 am             3,190 Program.cs
26/09/2023  05:29 am             4,096 Program.exe  <----- no "/out:" so Program.exe is generated
26/09/2023  05:19 am    <DIR>          Properties
               5 File(s)         13,470 bytes
               5 Dir(s)  489,139,777,536 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>Program.exe
Moo Version 1

-------------------------turn to comment---------------

using System;

class MeMainClass
{
    static void Main()
    {
        Cow.Moo();
    }
}
-----------------------------------------------
-------------------------Created---------- will OverWrite Farm.dll 
using System;
using System.Reflection;

[assembly: AssemblyVersion("2.0.0.0")]          

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Moo Version 2");
    }
}

------------------------------------------

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>ildasm /out:MeIl.txt Program.exe

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>MeIl.txt
--------------------NOTEPAD: MEIl.txt------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern Farm
{
  .ver 1:0:0:0      <-------------------------will be overwritten if csc /t:library /out:Farm.dll Program.cs
}
.assembly Program
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Program.exe
// MVID: {15014633-AE0C-4618-8A08-B108636FAFEE}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x07040000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MeMainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  call       void [Farm]Cow::Moo()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MeMainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MeMainClass::.ctor

} // end of class MeMainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file MeIl.res


--------------------NOTEPAD: MEIl.txt------------------------END

----------OverWrite Farm.dll---------[assembly: AssemblyVersion("2.0.0.0")] -----------------
C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version

26/09/2023  05:49 am    <DIR>          .
26/09/2023  05:49 am    <DIR>          ..
26/09/2023  05:09 am               189 App.config
26/09/2023  05:09 am    <DIR>          bin
26/09/2023  05:23 am             2,411 DotNet Assembly Version.csproj
26/09/2023  05:49 am             3,584 Farm.dll
26/09/2023  05:46 am             1,128 MeIl.res
26/09/2023  05:46 am             4,889 MeIl.txt
26/09/2023  05:09 am    <DIR>          obj
26/09/2023  05:49 am            10,992 Program.cs
26/09/2023  05:29 am             4,096 Program.exe
26/09/2023  05:19 am    <DIR>          Properties
               7 File(s)         27,289 bytes
               5 Dir(s)  489,281,830,912 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>ildasm /out:MeIl.txt Farm.dll

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>MeIl.txt
------------------------NOTEPAD: MeIl.txt-------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Farm
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 2:0:0:0          <----------------------OVERWRITTEN
}
.module Farm.dll
// MVID: {63B48200-6841-4079-9C40-755273C73690}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06E80000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class public auto ansi beforefieldinit Cow
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Moo() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Moo Version 2"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method Cow::Moo

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Cow::.ctor

} // end of class Cow


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file MeIl.res


------------------------NOTEPAD: MeIl.txt-------------------------END
C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>Program.exe
Moo Version 2

---------------------DotNet Assembly Public Key Private Key---------------------------------------------------

C:\Users\sunny\source\repos\DotNet Assembly Public Key Private Key\DotNet Assembly Public Key Private Key>sn

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Usage: sn [-q|-quiet] <option> [<parameters>]
 Options:
  -a identityPublicKeyFile identityKeyPairFile signaturePublicKeyFile
    Generate AssemblySignatureKeyAttribute data to migrate the identity key to the signature key from a file.
  -ac identityPublicKeyFile identityKeyPairContainer signaturePublicKeyFile
    Generate AssemblySignatureKeyAttribute data to migrate the identity key to the signature key from a key container.
  -c [<csp> [<provtype>] ]
    Set/reset the name of the CSP to use for MSCORSN operations.
  -d <container>
    Delete key container named <container>.
  -dg <assembly> <digest file> [-rehash]
    Compute the digest of an assembly, generating a digest file for signing by
    the -ds or -dsc commands.
    If -rehash is specified, modules are re-hashed before digest calulation
  -ds <digest file> <keyfile> [-ecma]
    Sign a digest file generated by the -dg command using the full key pair
    from the given key file.
    If -ecma is used, keyfile is treated as the real key for ECMA signing.
  -dsc <digest file> <container> [-ecma]
    Sign a digest filegenerated by the -dg command using the key in the
    specified key container.
    If -ecma is used, container is treated as the real key for ECMA signing.
  -di <digest file> <assembly>
    Insert the signature from the digest file signed by the -ds or -dsc
    commands into the assembly.
  -dh <digest file> <hash file>
    Extract the base64 encoded hash value from the digest file
  -du <signature file> <digest file>
    Update the signature in the digest file with a base64 encoded signature
    in a signature file. WARNING: using this operation may result in a digest
    file that contains an invalid signature for its corresponding assembly.
  -dd <digest file>
    Dump the digest file to the console
  -D <assembly1> <assembly2>
    Verify <assembly1> and <assembly2> differ only by signature.
  -e <assembly> <outfile>
    Extract public key from <assembly> into <outfile>.
  -i <infile> <container>
    Install key pair from <infile> into a key container named <container>.
  -k [<keysize>] <outfile>
    Generate a new key pair of the specified size and write it into <outfile>.
  -m [y|n]
    Enable (y), disable (n) or check (no parameter) whether key containers
    are machine specific (rather than user specific).
  -o <infile> [<outfile>]
    Convert public key in <infile> to text file <outfile> with comma separated
    list of decimal byte values.
    If <outfile> is omitted, text is copied to clipboard instead.
  -p <infile> <outfile> [<hashalg>]
    Extract public key from key pair in <infile> and export to <outfile>,
    embedding the specified hash algorithm (sha1|sha256|sha384|sha512).
  -pc <container> <outfile> [<hashalg>]
    Extract public key from key pair in <container> and export to <outfile>,
    embedding the specified hash algorithm (sha1|sha256|sha384|sha512).
  -Pb [y|n]
    Enable (y), disable (n) or check (no parameters) the CLR policy allowing
    trusted applications to bypass strong name signature verification on their
    assemblies.
  -q
    Quiet mode. This option must be first on the command line and will suppress
    any output other than error messages.
  -R[a] <assembly> <infile> [-ecma]
    Re-sign signed or partially signed assembly with the key pair in <infile>.
    If -Ra is used, hashes are recomputed for all files in the assembly.
    If -ecma is used, infile is treated as the real key for ECMA signing.
  -Rc[a] <assembly> <container> [-ecma]
    Re-sign signed or partially signed assembly with the key pair in the key
    container named <container>.
    If -Rca is used, hashes are recomputed for all files in the assembly.
    If -ecma is used, container is treated as the real key for ECMA signing.
  -Rh <assembly>
    Re-compute hashes for all files in the assembly.
  -t[p] <infile>
    Display token for public key in <infile> (together with the public key
    itself if -tp is used).
  -T[p] <assembly>
    Display token for public key of <assembly> (together with the public key
    itself if -Tp is used).
  -TS <assembly> <infile>
    Test-sign signed or partially signed assembly with the key pair in
    <infile>.
  -TSc <assembly> <container>
    Test-sign signed or partially signed assembly with the key pair in the key
    container named <container>.
  -v[f] <assembly> [{-ecmakey <keyfile> | -ecmacontainer <container>}]
    Verify <assembly> for strong name signature self consistency. If -vf is
    specified, force verification even if disabled in the registry.
    If -ecmakey is specified, keyfile is treated as the real ECMA key.
    If -ecmacontainer is specified, container is treated as the real ECMA key.
  -Vk <regfile> <assembly> [<userlist>] [<testkey>]
    Generate a registry script in <regfile> to register <assembly> for
    verification skipping (with an optional, comma separated list of usernames
    for which this will take effect and an optional test public key in
    <testkey>). <assembly> can be specified as * to indicate all assemblies or
    *,<public key token> to indicate that all assemblies with the given public
    key token. Public key tokens should be specified as a string of hex digits.
  -Vl
    List current settings for strong name verification on this machine.
  -Vr <assembly> [<userlist>] [<infile>]
    Register <assembly> for verification skipping (with an optional, comma
    separated list of usernames for which this will take effect and an
 optional test public key in <infile>).
 <assembly>    can be specified as * to indicate all assemblies or *,<public key token> to
    indicate that all assemblies with the given public key token. Public key
    tokens should be specified as a string of hex digits.
  -Vu <assembly>
    Unregister <assembly> for verification skipping. The same rules for
    <assembly> naming are followed as for -Vr.
  -Vx
    Remove all verification skipping entries.
  -?
  -h
    Displays this help text.

C:\Users\sunny\source\repos\DotNet Assembly Public Key Private Key\DotNet Assembly Public Key Private Key>sn -k KulpotKey.snk

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to KulpotKey.snk

C:\Users\sunny\source\repos\DotNet Assembly Public Key Private Key\DotNet Assembly Public Key Private Key>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Public Key Private Key\DotNet Assembly Public Key Private Key

27/09/2023  05:35 am    <DIR>          .
27/09/2023  05:35 am    <DIR>          ..
27/09/2023  05:19 am               189 App.config
27/09/2023  05:19 am    <DIR>          bin
27/09/2023  05:19 am             2,426 DotNet Assembly Public Key Private Key.csproj
27/09/2023  05:35 am               596 KulpotKey.snk
27/09/2023  05:19 am    <DIR>          obj
27/09/2023  05:34 am            24,227 Program.cs
27/09/2023  05:19 am    <DIR>          Properties
               4 File(s)         27,438 bytes
               5 Dir(s)  488,700,121,088 bytes free



 * 
 */


//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moo Version 1");
//    }
//}

//class MeMainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//    }
//}

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Moo Version 2");
    }
}