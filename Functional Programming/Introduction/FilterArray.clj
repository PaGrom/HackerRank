;; https://www.hackerrank.com/challenges/fp-filter-array

(fn [delim lst]
    (reduce #(if (< %2 delim) (conj %1 %2) %1) [] lst))
