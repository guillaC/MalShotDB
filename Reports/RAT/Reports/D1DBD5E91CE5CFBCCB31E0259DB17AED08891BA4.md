![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
# RedDevil product - RedDevil v1.0.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | RedDevil v1.0.exe |
| Product Name | RedDevil product |
| Version Number | 1.0.0.0 |
| Description | RedDevil |
| Company Name | RedDevil company |
| Copyright | RedDevil copyright |
| Trademarks |  |
| Last Edition | 19/08/2022 03:21:22 |
| Size | 3628544 |
| SHA1 🔎 | [D1DBD5E91CE5CFBCCB31E0259DB17AED08891BA4](https://www.virustotal.com/gui/search/D1DBD5E91CE5CFBCCB31E0259DB17AED08891BA4) |
| MD5 | D41D8CD98F00B204E9800998ECF8427E |
| Language | Langue neutre |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/aTest/Desktop/net6.0/Malwares/Malwares/RAT/Red Devil Remote Admin/RedDevil v1.0.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:     IMAGE_FILE_MACHINE_I386
Subsystem:        IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date: 2015-Sep-04 19:21:23
Comments:         Remote admin tools
CompanyName:      RedDevil company
FileDescription:  RedDevil
FileVersion:      1.0.0.0
InternalName:     RedDevil v1.0.exe
LegalCopyright:   RedDevil copyright
OriginalFilename: RedDevil v1.0.exe
ProductName:      RedDevil product
ProductVersion:   1.0.0.0
Assembly Version: 1.0.0.0

DOS Header:
-----------
e_magic:    MZ
e_cblp:     0x0090
e_cp:       0x0003
e_crlc:     0x0000
e_cparhdr:  0x0004
e_minalloc: 0x0000
e_maxalloc: 0xFFFF
e_ss:       0x0000
e_sp:       0x00B8
e_csum:     0x0000
e_ip:       0x0000
e_cs:       0x0000
e_ovno:     0x0000
e_oemid:    0x0000
e_oeminfo:  0x0000
e_lfanew:   0x00000080

PE Header:
----------
Signature:            PE
Machine:              IMAGE_FILE_MACHINE_I386
NumberofSections:     4
TimeDateStamp:        2015-Sep-04 19:21:23
PointerToSymbolTable: 0x00000000
NumberOfSymbols:      0
SizeOfOptionalHeader: 0x00E0
Characteristics:      IMAGE_FILE_32BIT_MACHINE
                      IMAGE_FILE_EXECUTABLE_IMAGE
                      IMAGE_FILE_LINE_NUMS_STRIPPED
                      IMAGE_FILE_LOCAL_SYMS_STRIPPED

Image Optional Header:
----------------------
Magic:                   PE32
LinkerVersion:           6.0
SizeOfCode:              0x0033C800
SizeOfInitializedData:   0x00039200
SizeOfUninitializedData: 0x00000000
AddressOfEntryPoint:     0x0033E62E (Section: .text)
BaseOfCode:              0x00002000
BaseOfData:              0x00340000
ImageBase:               0x00400000
SectionAlignment:        0x00002000
FileAlignment:           0x00000200
OperatingSystemVersion:  4.0
ImageVersion:            0.0
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x0037E000
SizeOfHeaders:           0x00000400
Checksum:                0x00000000
Subsystem:               IMAGE_SUBSYSTEM_WINDOWS_GUI
SizeofStackReserve:      0x00100000
SizeofStackCommit:       0x00001000
SizeofHeapReserve:       0x00100000
SizeofHeapCommit:        0x00001000
LoaderFlags:             0x00000000
NumberOfRvaAndSizes:     15

Sections:
---------
.text:
    VirtualSize:          0x0033C634
    VirtualAddress:       0x00002000
    SizeOfRawData:        0x0033C800
    PointerToRawData:     0x00000400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_CODE
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
    Entropy:              7.44622

.sdata:
    VirtualSize:          0x00000162
    VirtualAddress:       0x00340000
    SizeOfRawData:        0x00000200
    PointerToRawData:     0x0033CC00
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              6.00916

.rsrc:
    VirtualSize:          0x00038D18
    VirtualAddress:       0x00342000
    SizeOfRawData:        0x00038E00
    PointerToRawData:     0x0033CE00
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
    Entropy:              5.59115

.reloc:
    VirtualSize:          0x0000000C
    VirtualAddress:       0x0037C000
    SizeOfRawData:        0x00000200
    PointerToRawData:     0x00375C00
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_DISCARDABLE
                          IMAGE_SCN_MEM_READ
    Entropy:              0.10191


Imports:
--------
mscoree.dll: _CorExeMain

Resources:
----------
2:
    Type:              RT_ICON
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              67062
    TimeDateStamp:     1980-Jan-01 00:00:00
    Entropy:           7.99044
    Detected Filetype: PNG graphic file

3:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          67624
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       3.963

4:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          38056
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.0994

5:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          21640
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.12649

6:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          16936
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.11754

7:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          9640
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.26034

8:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          4264
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.39888

9:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2440
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.53314

10:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1128
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.54636

32512:
    Type:              RT_GROUP_ICON
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              132
    TimeDateStamp:     1980-Jan-01 00:00:00
    Entropy:           3.07647
    Detected Filetype: Icon file

1:
    Type:          RT_VERSION
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          856
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       3.27853

1 (#2):
    Type:          RT_MANIFEST
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2259
    TimeDateStamp: 1980-Jan-01 00:00:00
    Entropy:       4.94474


Version Info:
-------------
Resource LangID: UNKNOWN
VS_VERSION_INFO:
    Signature:           0xFEEF04BD
    StructVersion:       0x00010000
    FileVersion:         1.0.0.0
    ProductVersion:      1.0.0.0
    FileFlags:           (EMPTY)
    FileOs:              VOS_DOS_WINDOWS32
                         VOS_NT_WINDOWS32
                         VOS__WINDOWS32
    FileType:            VFT_APP
    Language:            UNKNOWN
    Comments:            Remote admin tools
    CompanyName:         RedDevil company
    FileDescription:     RedDevil
    FileVersion (#2):    1.0.0.0
    InternalName:        RedDevil v1.0.exe
    LegalCopyright:      RedDevil copyright
    OriginalFilename:    RedDevil v1.0.exe
    ProductName:         RedDevil product
    ProductVersion (#2): 1.0.0.0
    Assembly Version:    1.0.0.0


Matching compiler(s):
    Microsoft Visual C# v7.0 / Basic .NET

Cryptographic algorithms detected in the binary:
    Uses constants related to MD5

[ SUSPICIOUS ] 
    Unusual section name found: .sdata

The following exploit mitigation techniques have been detected
    Stack Canary: disabled
    SafeSEH: disabled
    ASLR: disabled
    DEP: disabled
    CFG: disabled




```

</p>
</details>

## Screenshots
### Default Port
![UI](./Screenshots/Default%20Port_Default%20Port_6a652070fea14651a866152f37cf4e01.png) 
