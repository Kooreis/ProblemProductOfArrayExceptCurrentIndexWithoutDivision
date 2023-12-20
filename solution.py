Here is a Python console application that solves the problem:

```python
def product_except_self(nums):
    length = len(nums)
    answer = [0]*length

    answer[0] = 1
    for i in range(1, length):
        answer[i] = nums[i - 1] * answer[i - 1]

    R = 1;
    for i in reversed(range(length)):
        answer[i] = answer[i] * R
        R *= nums[i]

    return answer

def main():
    nums = list(map(int, input("Enter numbers separated by space: ").split()))
    print(product_except_self(nums))

if __name__ == "__main__":
    main()
```

This console application first asks the user to input a list of numbers separated by spaces. It then calculates the product of all numbers in the list except for the current index for each number in the list, and prints the result.