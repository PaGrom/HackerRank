;; https://www.hackerrank.com/challenges/fp-sum-of-odd-elements

 (fn[lst]
    (reduce + (filter odd? lst)))
