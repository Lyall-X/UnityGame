local NoticeTable = class("NoticeTable")

function NoticeTable:Initialize()
    self.Items = {
        [1] = {id = 1, title = '标题1', content = '怪物来袭', time = '2021.9.1'},
        [2] = {id = 2, title = '标题2', content = '怪物来袭', time = '2021.9.9'}
	}
end

function NoticeTable:GetItems()
    return self.Items
end

function NoticeTable:GetItemByKey(key)
    return self.Items[key]
end

return NoticeTable