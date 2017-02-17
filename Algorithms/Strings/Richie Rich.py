# https://www.hackerrank.com/challenges/richie-rich

#!/bin/python

import sys

n, k = map(int, raw_input().split())
nums = [(int(i), False) for i in list(raw_input())]
for i in range(0, n/2):
    numA, numB = nums[i], nums[-i-1]
    if numA[0] > numB[0] and k > 0:
        numB = (numA[0], True)
        k -= 1
    if numB[0] > numA[0] and k > 0:
        numA = (numB[0], True)
        k -= 1
    nums[i], nums[-i-1] = numA, numB

for i in range(0, n/2):
    numA, numB = nums[i], nums[-i-1]
    if numA[0] != 9 and numB[0] != 9:
        if numA[1] == numB[1] and k > 1:
            k -= 2*(not numA[1])
            numA, numB = (9, True), (9, True)
        elif numA[1] != numB[1] and k > 0:
            k -= 1
            numA, numB = (9, True), (9, True)
    nums[i], nums[-i-1] = numA, numB

if n % 2 == 1 and k > 0:
    nums[n/2] = (9, True)
    k -= 1

res = "".join(map(lambda x: str(x[0]), nums))
if res == res[::-1]:
    print res
else:
    print -1
