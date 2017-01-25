;; https://www.hackerrank.com/challenges/fp-list-replication

(fn [num lst]
    (mapcat #(repeat num %) lst))
