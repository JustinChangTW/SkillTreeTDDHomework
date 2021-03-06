# SkillTreeTDDHomework

## Day1
### 測試樣本
|   Id  |   Cost  | Revenue  |  SellPrice   |
|:-----:|:-------:|:--------:|:------------:|
|   1   |     1	  |    11	   |    21        |
|   2	|2	|12	|22|
|3	|3	|13	|23|
|4	|4	|14	|24|
|5	|5	|15	|25|
|6	|6	|16	|26|
|7	|7	|17	|27|
|8	|8	|18	|28|
|9	|9	|19	|29|
|10	|10	|20	|30|
|11	|11	|21	|31|
			
			
### 結果
|Sample	|行為|	結果|
|:----:|:-----:|:-------:|
|1	|3筆一組，取Cost總和	|6,15,24,21|	
|2	|4筆一組，取Revenue總和	|50,66,60|	
			
			
### 題目解說			
1. 來源可以是「任何型別的集合」
2. 可以任意決定幾筆一組
3. 回傳每一組 Σf(x) 的集合
    - Σ結果型別可直接用int


### 作業規範：
1. 只收 gist 與 GitHub, 強烈建議為 GitHub，因為 day 2 homework 只收 GitHub
2. 作業可以只交 test case，如果你想挑戰 production code 十分歡迎，但請務必先寫好 test case
3. 測試資料請勿使用迴圈產生，因為這資料只是「剛好」長這樣

### 需求：
1. 該11筆資料，如果要3筆成一組，取得Cost的總和的話，預期結果是 6,15, 24, 21
2. 該11筆資料，如果是4筆一組，取得 Revenue 總和的話，預期結果會是 50,66,60
3. 筆數輸入負數，預期會拋 ArgumentException
4. 尋找的欄位若不存在，預期會拋 ArgumentException
5. 筆數若輸入為0, 則傳回0
6. 未來可能會新增其他欄位
7. 希望這個API可以給其他 domain entity 用，例如 Employee
