---
title: Avoid C# dictionaries
difficulty: 1 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Using C#'s Dictionary. Especially if you're using string-keys.
<!--try-->
An int-key dictionary. Or even better, an alternative data-structure.

For game catered datastructures, <a href="https://github.com/dotBunny/GDX">check out GDX</a>. GDX is an open-source collection of custom data-types geared towards gamedev and performance.
<!--because-->
C#'s built in data types are geared towards maximum flexibility and sacrifice performance for it. <b>Especially string-key dictionaries.</b> String-key dictionaries will hash strings every time you use it, which is very slow.

Getting the right data-type will not only be faster, but give you catered architecture to best solve your problems.