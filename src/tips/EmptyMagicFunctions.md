---
title: Empty Start(), Update(), Etc...
difficulty: 1 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Leaving empty Unity callback methods laying around.
<!--try-->
Deleting them!
<!--because-->
Turns out Unity will not optimize out those functions that they put there for you. Remember that Start function in every MonoBehaviour that you left there? They're slowing you down. Delete 'em!