import math

def minway (a, b):
  val=(math.inf, -1, -1)
  for i in b:
    fval=min(a, key=lambda x: x[0] if (x[1] == i or x[2] == i) and (x[1] not in b or x[2] not in b) else math.inf)
    if math.inf!=fval[0]:
      val=fval
    return val

a=[(math.inf, -1, -1), (15, 1, 2), (23, 1, 4), (14, 1, 5), (19, 2, 3), (15, 2, 5), (16, 2, 4), (15, 2, 5), (14, 3, 5), (26, 3, 6), (23, 4, 7), (25, 4, 5), (24, 5, 6), (20, 4, 8), (27, 5, 8), (18, 5, 9), (18, 8, 9), (14, 7, 8)]
c=9
b={1}
d=[]
while len(b)<c:
  f=minway(a, b)
  if f[0]==math.inf:
    break
  d.append(f)
  b.add(f[1])
  b.add(f[2])
print(d)
