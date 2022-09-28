![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
# Lost door® - Lost Door V4.3.1.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | Lost Door V4.3.1.exe |
| Product Name | Lost door® |
| Version Number | 4.03 |
| Description | By OussamiO |
| Company Name | Hackers®Insides |
| Copyright | Hackers®Inside |
| Trademarks | Lost door® |
| Last Edition | 04/04/2010 15:35:32 |
| Size | 2399232 |
| SHA1 🔎 | [AD383AF065BD5FF8EDBE4FFC0D0ACC24500AF99D](https://www.virustotal.com/gui/search/AD383AF065BD5FF8EDBE4FFC0D0ACC24500AF99D) |
| MD5 | D41D8CD98F00B204E9800998ECF8427E |
| Language | Anglais (États-Unis) |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/aTest/Desktop/net6.0/Malwares/Lost Door v4.3.1/Lost Door V4.3.1.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:       IMAGE_FILE_MACHINE_I386
Subsystem:          IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date:   2010-Apr-04 13:31:22
Detected languages: Arabic - Tunisia
                    Arabic - U.A.E.
                    English - United States
                    French - France
Comments:           By OussamiO
CompanyName:        Hackers┬«Insides
FileDescription:    By OussamiO
LegalCopyright:     Hackers┬«Inside
LegalTrademarks:    Lost door┬«
ProductName:        Lost door┬«
FileVersion:        4.03
ProductVersion:     4.03
InternalName:       Lost Door V4.3.1
OriginalFilename:   Lost Door V4.3.1.exe

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
e_lfanew:   0x000000C8

PE Header:
----------
Signature:            PE
Machine:              IMAGE_FILE_MACHINE_I386
NumberofSections:     3
TimeDateStamp:        2010-Apr-04 13:31:22
PointerToSymbolTable: 0x00000000
NumberOfSymbols:      0
SizeOfOptionalHeader: 0x00E0
Characteristics:      IMAGE_FILE_32BIT_MACHINE
                      IMAGE_FILE_EXECUTABLE_IMAGE
                      IMAGE_FILE_LINE_NUMS_STRIPPED
                      IMAGE_FILE_LOCAL_SYMS_STRIPPED
                      IMAGE_FILE_RELOCS_STRIPPED

Image Optional Header:
----------------------
Magic:                   PE32
LinkerVersion:           6.3
SizeOfCode:              0x00244000
SizeOfInitializedData:   0x00006000
SizeOfUninitializedData: 0x0058D000
AddressOfEntryPoint:     0x007D1760 (Section: text)
BaseOfCode:              0x0058E000
BaseOfData:              0x007D2000
ImageBase:               0x00400000
SectionAlignment:        0x00001000
FileAlignment:           0x00000200
OperatingSystemVersion:  4.0
ImageVersion:            4.3
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x007D8000
SizeOfHeaders:           0x00001000
Checksum:                0x00000000
Subsystem:               IMAGE_SUBSYSTEM_WINDOWS_GUI
SizeofStackReserve:      0x00100000
SizeofStackCommit:       0x00001000
SizeofHeapReserve:       0x00100000
SizeofHeapCommit:        0x00001000
LoaderFlags:             0x00000000
NumberOfRvaAndSizes:     16

Sections:
---------
code:
    VirtualSize:          0x0058D000
    VirtualAddress:       0x00001000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x00000400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_UNINITIALIZED_DATA
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

text:
    VirtualSize:          0x00244000
    VirtualAddress:       0x0058E000
    SizeOfRawData:        0x00243A00
    PointerToRawData:     0x00000400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              7.87903

.rsrc:
    VirtualSize:          0x00006000
    VirtualAddress:       0x007D2000
    SizeOfRawData:        0x00005E00
    PointerToRawData:     0x00243E00
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              6.15694


Imports:
--------
KERNEL32.DLL: LoadLibraryA
              GetProcAddress
              VirtualProtect
              VirtualAlloc
              VirtualFree
              ExitProcess
MSVBVM60.DLL: #581

Resources:
----------
101:
    Type:          CUSTOM
    Language:      French - France
    Codepage:      Unicode (UTF 16LE)
    Size:          84992
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.88024

102:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          11264
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.68934

103:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          196572
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.92262

104:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          119384
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.71676

105:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          271016
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.79756

106:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          119384
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.74925

107:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          24640
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.58934

108:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          104492
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.66862

109:
    Type:          CUSTOM
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          43764
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.66503

110:
    Type:          CUSTOM
    Language:      French - France
    Codepage:      Unicode (UTF 16LE)
    Size:          2884
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.77778

1:
    Type:          RT_CURSOR
    Language:      French - France
    Codepage:      Unicode (UTF 16LE)
    Size:          308
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       6.93568

101 (#2):
    Type:          RT_BITMAP
    Language:      French - France
    Codepage:      Unicode (UTF 16LE)
    Size:          67872
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.73635

1 (#2):
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.61218

2:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.72792

3:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.7306

4:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.74585

5:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.61972

6:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.58184

7:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.67303

8:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.5976

9:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.63857

10:
    Type:          RT_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       7.60433

30001:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      Unicode (UTF 16LE)
    Size:          20580
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       6.47668

101 (#3):
    Type:          RT_GROUP_CURSOR
    Language:      Arabic - Tunisia
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.22193

1 (#3):
    Type:              RT_GROUP_ICON
    Language:          UNKNOWN
    Codepage:          Unicode (UTF 16LE)
    Size:              20
    TimeDateStamp:     2010-Apr-04 13:31:21
    Entropy:           2.42322
    Detected Filetype: Icon file

101 (#4):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.02193

102 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.22193

103 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.12193

104 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.32193

105 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.12193

106 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.22193

107 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.22193

108 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.32193

109 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.22193

110 (#2):
    Type:          RT_GROUP_ICON
    Language:      Arabic - U.A.E.
    Codepage:      Unicode (UTF 16LE)
    Size:          20
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       4.12193

1 (#4):
    Type:          RT_VERSION
    Language:      English - United States
    Codepage:      Unicode (UTF 16LE)
    Size:          828
    TimeDateStamp: 2010-Apr-04 13:31:21
    Entropy:       3.31688


Version Info:
-------------
Resource LangID: English - United States
VS_VERSION_INFO:
    Signature:           0xFEEF04BD
    StructVersion:       0x00010000
    FileVersion:         4.3.0.0
    ProductVersion:      4.3.0.0
    FileFlags:           (EMPTY)
    FileOs:              VOS_DOS_WINDOWS32
                         VOS_NT_WINDOWS32
                         VOS__WINDOWS32
    FileType:            VFT_APP
    Language:            English - United States
    Comments:            By OussamiO
    CompanyName:         Hackers┬«Insides
    FileDescription:     By OussamiO
    LegalCopyright:      Hackers┬«Inside
    LegalTrademarks:     Lost door┬«
    ProductName:         Lost door┬«
    FileVersion (#2):    4.03
    ProductVersion (#2): 4.03
    InternalName:        Lost Door V4.3.1
    OriginalFilename:    Lost Door V4.3.1.exe


RICH Header:
------------
XOR Key:          0x88CEA841
Unmarked objects: 0
14 (7299):        1
9 (8041):         67
13 (8169):        1

[ SUSPICIOUS ] PEiD Signature:
    UPX V2.00-V2.90 -> Markus Oberhumer &amp; Laszlo Molnar &amp; John Reiser
    UPX v2.0 -> Markus, Laszlo & Reiser (h)
    UPX -> www.upx.sourceforge.net
    UPX V2.00-V2.90 -> Markus Oberhumer & Laszlo Molnar & John Reiser

[ SUSPICIOUS ] The PE is possibly packed.
    Unusual section name found: code
    Section code is both writable and executable.
    Unusual section name found: text
    Section text is both writable and executable.
    The PE only has 7 import(s).

[ SUSPICIOUS ] The PE contains functions most legitimate programs don't use.
    [!] The program may be hiding some of its imports:
        LoadLibraryA
        GetProcAddress
    Memory manipulation functions often used by packers:
        VirtualProtect
        VirtualAlloc

The PE's resources present abnormal characteristics.
    Resource 101 is possibly compressed or encrypted.
    Resource 102 is possibly compressed or encrypted.
    Resource 103 is possibly compressed or encrypted.
    Resource 104 is possibly compressed or encrypted.
    Resource 105 is possibly compressed or encrypted.
    Resource 106 is possibly compressed or encrypted.
    Resource 107 is possibly compressed or encrypted.
    Resource 108 is possibly compressed or encrypted.
    Resource 109 is possibly compressed or encrypted.
    Resource 110 is possibly compressed or encrypted.
    Resource 101 is possibly compressed or encrypted.
    Resource 1 is possibly compressed or encrypted.
    Resource 2 is possibly compressed or encrypted.
    Resource 3 is possibly compressed or encrypted.
    Resource 4 is possibly compressed or encrypted.
    Resource 5 is possibly compressed or encrypted.
    Resource 6 is possibly compressed or encrypted.
    Resource 7 is possibly compressed or encrypted.
    Resource 8 is possibly compressed or encrypted.
    Resource 9 is possibly compressed or encrypted.
    Resource 10 is possibly compressed or encrypted.

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
### Lost Door
![UI](./Screenshots/Lost%20Door_Lost%20Door_882585c4a50e4a89a2d6e6cb9e2ad7a1.png) 
