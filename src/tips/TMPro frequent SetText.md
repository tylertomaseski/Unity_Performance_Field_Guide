---
title: TMPro frequent SetText() calls
difficulty: 1 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
TMPro.TMP_Base.SetText() every frame
<!--try-->
Set once, only update when the text changes!
<!--because-->
Rebuilding TMPro text meshes is slow and it does it every time you set the text value! And so is its rich text support. Avoid setting text unless the contents have changed.