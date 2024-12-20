﻿using Stellamod.NPCs.Bosses.Ereshkigal;
using Stellamod.NPCs.Bosses.Zui;
using Stellamod.NPCs.Bosses.Zui.Projectiles;
using Stellamod.NPCs.Town;

namespace LunarVeilChinesePack.NPCs;
public class TownNPCLocalizer : ModSystem
{
    public override void Load()
    {
        #region Aimacra 安魅凯拉
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetBestiary), new() {
            { "Aimacra??? From Diari?? Crazy", "安魅凯拉？？？从Diari来的？？好疯狂噢！" },
            { "Aimacra", "安魅凯拉" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.GetChat), new() {
            { "They also have fox ears like me lmao", "她也像我一样拥有狐狸的耳朵啊（憋笑）" },
            { "This world seems a bit off don't you think?", "你是否也觉得这个世界有点不对劲呢？" },
            { "I'm not one to brag but this place is so much better than Ekrose", "我不是喜欢夸夸其谈的人，但这个地方确实比艾科洛斯好多了." },
            { "Did Sirestias ask me to find her again?", "希丝忒莉亚又叫我去找她了吗？" },
            { "Yeah I've been traveling while you were out.", "遇到你之前我一直在游荡" },
            { "Go play Diari on steam? I have no idea what that means", "要不要试着steam下载个Diari玩玩？等等，我在说什么" },
            { "Do people think I'm not into pans?", "是不是大家都认为我不喜欢平底锅呢？" },
            { "Sooo can we forget about everything that happened in Ekrose?", "我们可以忘记在艾科洛斯发生的一切吗？" },
            { "I am really sorry for what we went through but now were here you know?", "我真的很抱歉我们曾经所经历的一切，但是现在我们在这里应该有个新的开始，不是吗？" },
            { "Sirestias went out again, and this time I'm not finding her.", "希丝忒莉亚又出去了，这次我可不会再去找她了" },
            { "Hey could you go do something, I'm about to get dressed, but honestly I say that like you haven't seen me before.", "嘿，我要换衣服，你能去做点别的事情吗？但说实在的，你以前又不是没见过我换衣服." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Aimacra), nameof(Aimacra.SetNPCNameList), new() {
            // 安魅凯拉有三个名字,  一个是 Aimacra, 一个是 Aimacra, 一个还是 Aimacra
            { "Aimacra", "Aimacra" },
            { "Aimacra", "Aimacra" },
            { "Aimacra", "Aimacra" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetChatButtons), new() {
            { "Talk", "闲聊" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.OnChatButtonClicked), new() {
            { "Heyyy at least we're out of Ekrose alive! I'm glad Vixyl is safe back at the main house.", "唉，至少我们活着离开了艾科洛斯，维西尔也安全回到家乡，这已经是很好的结果了" },
            { "I hate being Sirestias's Assassin.. Speaking of I met a guy named Veldris and he's totally cool!", "我不喜欢当希丝忒莉亚的杀手，emmmmm，说到这个，我今天遇到了一个叫威狄尔斯的家伙，他超酷的好吧" },
            { "I'll be back I may go to look for some new stuff underground. ", "我会回来的，我可能会去地下寻找一些新东西" },
            { "What is a thug shaker? To shake or not to shake? Sometimes I wonder if life truly does give lemons.", "什么才算是一个狂热摇滚者呢?随音乐摇摆还是不随音乐摇摆，这是一个问题...唉，有时候我感觉生活真是苦涩啊" },
            { "What class would I even be? ", "我在这里算什么职业呢...?" },
            { "Hey sorry for what may of happened on Ekrose but I hope we can still be friends and make up to each other.", "对于在艾科洛斯发生的事情，我深感抱歉，我们还可以继续作患难与共的朋友吗?" },
            { "STARBOMBERS ARE ON THIS PLANET TOOOOO!!!", "这里怎么也有星爆者啊！！！" },
            { "I totally haven't been playing geometry dash.", "我今天没有摸鱼玩几何冲刺，快夸我(•ω•`)" },
            { "I've seen some weird things in my life, but never would I have thought Fenix would be more chronically horny than Sirestias, but to be fair Sirestias just gets more power doing that.", "我短暂的一生中，我见识过各种各样事物，但我真没想到会有人比希丝忒莉亚还要欲望高涨——指绯琦.那可是希丝忒莉亚的力量来源啊！" },
            { "I hate being part human.", "在对于自己有一半人类的血统这件事情上，我非常讨厌" },
        });
        #endregion
        #region Bordoc 波尔杜克
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetBestiary), new() {
            { "Steaming from the depths", "燃烧，冒烟" },
            { "Bordoc the eternal blacksmith", "铁匠波尔杜克" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.GetChat), new() {
            { "Shes got some great cogs", "她的零件不错" },
            { "BRMMMM", "喀 喀" },
            { "Everyone always uses me but never asked how I'm able to talk.. ", "所有认识我的人中，没人问过我是怎么说话的..." },
            { "I don't care I need to gamble", "我对赌博不屑一顾" },
            { "My armors are the best in the lands", "我打造的盔甲无可匹敌！" },
            { "Sirestias and Aimacra game by recently and they laughed at me because they thought my shop was useless", "希丝忒莉亚和安魅凯拉最近过来转了一圈，她们居然敢嘲笑我的工艺！" },
            { "Im always feeling hot!", "我炎热无比！" },
            { "Heh, nobody is as good as me", "我的技巧天下无双！" },
            { "Burning Burning, heat and heat", "燃烧，燃烧，热量，热量！" },
            { "I'm inpenetrable", "我坚固无比！" },
            { "Damn we have some hot shit here", "这里有点热啊" },
            { "Only I know that Gothivia has so many barriers between her and the rest of the world, nobody will be able to kill her.", "我只知道，歌瑟梵在她与世界之间设下了重重阻碍，没人能找到她." },
            { "Those idiot gintze have made a horrible decision, now they can't use my armors I made for them.", "那些玄铁蠢货们真是不识时务，现在他们用不了我造的盔甲了." },
            { "KRMMMKTEYYYMMMM BRMMMMM", "咯咯咯咯 嗡嗡嗡 咯吱咯吱" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Bordoc), nameof(Bordoc.SetNPCNameList), new() {
            { "Blacksmith BORDOC", "铁匠波尔杜克" },
            { "Blacksmith BORDOC", "铁匠波尔杜克" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetChatButtons), new() {
            { "Heart of the Morrow", "幽曦之心" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.OnChatButtonClicked), new() {
            { "I want you to prove to me you're ready to obtain this, I've given you a broken core, if you restore its power, it's all yours. Show me your determination to be Gothivia's doll! You won't be the first to fail.. And maybe she'll come to thank you one day. ", "向我证明你值得拥有它：这是一个破损的核心，如果你能修复它，它就归你了.你对歌瑟梵的忠诚能够支持你走出这一步吗？如果你失败了,你可不是第一个.如果你成功了，她会由衷感谢你的." },
        });
        #endregion
        #region BoundGia 受缚的吉娅
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.OnKill), new() {
            { "Im being taken away help!", "我被抓走了！救命！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.SetBestiary), new() {
            { "A bound scientist lurking in the Virulent", "瘴煞之地的一名被绑架的科学家" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.GetChat), new() {
            { "Oh goodness thank you for saving me. I dont know how long I was tied up... I got stranded down here by a bunch of scouts I presume are from the morrow. I really caused a mess this time but I am really glad you saved me. D'you have a place to stay?", "天哪，太谢谢你帮我松绑了！我都记不清我在这里呆了多久...一群应该是幽曦那里的斥候把我扔到这就走了.正当我要放弃的时候你就把我救了！你有能住的地方吗？" },
        });
        #endregion
        #region CellConverter 分子转换器
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetBestiary), new() {
            { "Burning in a magical laboratory", "在一个古老的魔法工厂里仍然运转着" },
            { "The Cell converter", "分子转换器" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.GetChat), new() {
            { "KRTTCAVSJKSC", "咯咯 哒哒 吱 喀" },
            { "I WANT SCRAP", "我 要 废料" },
            { "MAKE YOUR SCRAP TOKENS FOR TRADE. KRM", "请 做 一些 废料 来 交换. 喀." },
            { "YEEERRRM", "呜呜呜 轰" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetNPCNameList), new() {
            { "Cell Converter", "分子转换器" },
            { "Cell Converter", "分子转换器" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetChatButtons), new() {
            { "Put in scrap token", "放入废料" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.OnChatButtonClicked), new() {
            { "Weapon Converted!", "武器 类型 已 转化 完成" },
            { "KRRRT, Sensors say you have inputed a token, here you go per request.", "咯咯， 传感器 检测 到 废料， 给 你 东西" },
            { "Womp womp, looks like nothing for you!", "呜 呜， 没有 东西 给 你" },
            { "Error, try again.", "出现 错误， 请 再次 尝试" },
            { "Put in another token.", "请 继续 放入 废料" },
        });
        #endregion
        #region Delgrim 戴尔格林
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetBestiary), new() {
            { "A magical engineer huh?", "魔法，工匠？有趣..." },
            { "Delgrim the eternal engineer.", "永世工匠戴尔格林" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.GetChat), new() {
            { "You're chill aren't ya?", "你很冷静，不是吗？" },
            { "Everyone comes in for the same stuff, come and go please.", "每个人都为了锻造相关事情来到和离开这里，想必你也一样吧" },
            { "Another visitor?", "啊,又一位访客？" },
            { "What goes on in the world nowadays?", "现在世界形势如何？" },
            { "I don't mean trouble, but do as you please.", "我不想惹麻烦，但你也不必过于拘谨." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Magical Engineer Delgrim", "魔法工匠戴尔格林" },
            { "Magical Engineer Delgrim", "魔法工匠戴尔格林" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetChatButtons), new() {
            { "Old Tales", "听他讲些往事" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.OnChatButtonClicked), new() {
            { "An old time there was a thriving capital, we used to call it the Harboring Morrow. It was a thriving city under the protection of Gothivia, Verlia, and Irradia. I used to be a member. Gothivia loved every one of us, Verlia would be off directing armies and Irradia well she spent time making electronics. ", "很久很久以前，有一个繁荣的都城，我们过去称之为“幽曦城堡”.这是一座在歌瑟梵、薇莉亚和伊瑞蒂安保护下繁荣的城市.我曾经是其中的一员.歌瑟梵爱着我们每一个人，薇莉亚会指挥军队，而伊瑞蒂安则喜欢研究机械." },
            { "Irradia would make amazing tech, and I would come to every show she would host and watch her mechanic sword fights and spare parts, Verlia would sometimes participate and tear all of them apart. Verlia was just too good of a swordsman.", "伊瑞蒂安总会制造出令人惊叹的发明，我会去参加她主持的每一场演示，观看她的机械剑的战斗与战备演示.薇莉亚有时也会参与进来，将伊瑞蒂安的发明全部击败.不得不说，薇莉亚是一名很厉害的剑客." },
            { "Gothivia would always come down at 10 A.M in the morning to greet all the city members, it used to be the time of my life. She'd give us goodies and Rek would come by with his binding light to empower the underground and brighten things up. ", "歌瑟梵总会在早上10点降临，对城市所有成员进行问候，并给我们带来甜点，那曾是我生命中最快乐的时光.此外，莱克会给我们带来阳光，照亮地下的一切." },
            { "Verlia and Gothivia are sisters, although they don't look it anymore, they used to be twins yet they couldn't be different from each other. Verlia was always rambunctious and outgoing while Gothivia was a calm and loving soul, the two got along.", "虽然薇莉亚和歌瑟梵看起来并不像，而且性格也截然不同，但实际上她们两个是双胞胎姐妹.薇莉亚总是活泼好动，歌瑟梵静雅且富有爱心，两人相处得十分融洽" },
            { "Of all the inventions Irradia made, by far my favorite was a rendition of Gothivia's Rek called Havoc. It was a magnificent beast. It held it's own against Verlia in the shows, if only I could go back to those days. ", "在伊瑞蒂安制造的所有发明中，我最喜欢的是模仿歌瑟梵的莱克制作的“浩劫龙械”.它是一头壮丽的巨兽.在演示中，它甚至能够与薇莉亚抗衡，要是能回到过去的那些时光该多好啊." },
            { "Verlia always would be training the army, the gintze army wasn't exactly the most reliable mainly because of Verlia's idiocity and lack of care for danger. The army would always charge head first without a care for defense. I wonder where the army was when we were defending against the Carian warriors and knights", "因为薇莉亚那个笨蛋对危机意识的缺失，导致薇莉亚训练的玄铁军队实际上是并不可靠的.那支军队总是从不防御，只管冲锋在前.我在想，当我们在抵御卡利亚战士和骑士的时候，这支军队在哪儿呢？" },
            { "Some days I look back on the Harboring Morrow and wonder why we fell so hard. I remember BORDOC, an excellent blacksmith but too arrogant to read his ways. Irradia taught me some amazing things I carry with me today and all the people. the people.. ", "有时候，我不自矜会回忆起在“幽曦城堡”的时光，思考我们为何会如此彻底地衰落.我记得有一个名为波尔杜克的铁匠，他技艺高超，但他又过于自负不愿改变自己的生活方式.伊瑞蒂安教给了我一些令我至今受益匪浅的惊人之事，还有所有的人们……那些人们……" },
            { "You know, I had loved Irradia, until we seperated through war our connection was magically I would say. Damn witches and their artistry. I don't hate magic, but its the reason I lost so much. That commander, I will never forget the smirk on that face. So called Fenix and her army of Carian knights. ", "我曾经深爱着伊瑞蒂安，直到战争将我们分离，我们之间的缘分非常奇妙.魔女和魔法组合技真是令人头疼.我虽然不讨厌魔法，但魔法却是导致我和伊瑞蒂安分离的原因.我永远不会忘记作为指挥官的凤涅克斯以及她那些卡利亚骑士的军队脸上的战胜后的得意." },
            { "One day in the Harboring Morrow, the most joyous of days, some collectors came back infected by some strange disease, as you may know now it's called the Virulent. An acid like corruption that eats at the soul. It tore our village apart like the black plague. It weakened us, right before a Carian army swept us away at our worst, we stood no chance.", "那本该是充满欢乐的一天，但那一天一些外出旅行的人感染了被后世称为“瘴煞”的瘟疫回到了幽曦城堡.这种瘟疫像酸液一样侵蚀着我们的灵魂，它像黑死病一样袭击了我们的村庄.它大幅度削弱了我们的力量，然后卡利亚军队在危机时刻趁虚而入，以至于我们完全没有获胜的希望." },
            { "Verlia one day left the Morrow to search and make peace with the witches in the upcoming villages, she was by far the most magical out of the three of them, so she would stand a chance to help, when she came back, she was out of her mind.", "薇莉娅有一天离开了幽曦之地，去附近村庄寻找与魔女们和平相处的办法.她是她们三个中最有魔法天赋的，所以她也是最有机会能够找到破局之法的人.但是当她回来时，她已经陷入了疯狂." },
            { "When Verlia came back from her excursion, she well, gave information that changed the course of our lives. Me being in a relationship with Irradia I was able to be let in on that information. She shared to us a tome from a small witch village. This would a fatal mistake.", "当薇莉娅从她的旅途归来时，她提供了一些改变了我们生活方式的办法与建议.由于我和伊拉迪亚的关系，使得我也了解到那些办法与建议.薇莉娅和我们分享了一本来自一个魔女村庄的卷轴，但这也将是一切灾难的起点." },
            { "Verlia's excursion took place right when the corruption started occuring, she went to look for a way to heal the damaged. Gothivia would do her best to heal everyone but she was only one person in the biggest capital in terraria. ", "在瘟疫出现后，薇莉娅就出发去寻找治愈瘟疫的方法了.而歌瑟梵则尽她最大的努力去治疗每一个人，但她只有一个人，能尽的力量太有限了." },
            { "One harrowing day, a fox appears at the doorstep of Verlia and Gothivia's abode. I knew my eyes decieved me when I had seen the fox transform into a tall Nero, they are like human cats but I thought they'd been extinct for millenia! ", "在一个月黑风高的晚上，一只狐狸出现在薇莉娅和歌瑟梵的住宅门前.当我看到那只狐狸变成了一个高大的人形生物时，我才意识到她并不是狐狸，她是兽人！！！在遇到她之前，我以为她们种族已经灭绝了几千年了" },
            { "When a fox arrived on the doorsteps of our beloved, The fox lady brings out what I can only think was a lantern and all I could make out inside that room was a giant blue flash and the screams of Gothivia. This was the last time anyone heard of Verlia.", "当一位狐狸女士来到我心爱之人门前时，她拿出了一个我认为是灯笼的东西.然后一道巨大的蓝色闪光伴随着歌瑟梵的尖叫从屋内传出.然后薇莉娅就消失了." },
            { "After what I call the 'blue flash,' everyone hurried to a sign of screaming in the middle of the night. We all come to see Gothivia crying with a note in her hand and the fox lady. She introduced herself as Fenix. ", "“蓝色闪光”后，很多人急忙跑到尖叫发出的地方.但是我们只看到了手里拿着一张纸条哭泣的歌瑟梵，以及一位自称绯琦的狐狸女士." },
            { "Fenix was a tall statured woman yet extremely menacing, at times a lot of us thought she may have been more powerful than Gothivia, but deep down Gothivia's suppressed feelings for her family would probably overcome that. ", "绯琦是一位身材高大、看起来极其强大的女性，甚至我们中的很多人认为她比歌瑟梵更强大.但是大家又认为失去家人、在悲痛爆发的歌瑟梵力量会更强大." },
            { "The illnesses started to rack up and since Verlia disappeared, our Harboring Morrow was not complete, there was nobody to keep our armies in check, Gothivia wasn't mentally there anymore and Irradia was trying her best to get everyone to calm down. It was a horrible time.", "自从薇莉娅消失后，瘟疫快速蔓延，“幽曦城堡”已经名存实亡，没人维持军队秩序，歌瑟梵深受打击一蹶不振，伊瑞蒂安则在尽力安抚着所有人.那真是一段可怕的岁月." },
            { "Irradia did explain what happened to Verlia, but I thought it was just downright evil. Fenix trapped Verlia's soul inside a lantern and bounded it to a secret power for experimentation because she stole a book from their village. We'll never get to see her again will we?", "伊瑞蒂安向我解释了在薇莉娅身上发生了什么.因为薇莉娅从绯琦的村庄偷了一本书，绯琦将薇莉娅的灵魂困在灯笼里，并用秘密力量上在她身上进行实验，绯琦真是太邪恶了.我们或许再也见不到她了，对吧？" },
            { "I think Irradia's way of coping to the loss of Verlia was teaching me now that Im starting to recollect. She may have used it as a way of reflecting, and I didn't see that she was hurting yet I was always there for her.", "我曾经认为伊瑞蒂安教导我是为了冲淡失去薇莉娅的悲伤.但是我现在反应过来，她可能用这种方式来思念薇莉娅，虽然我当时没有意识到她的情绪，但我始终陪在她身边." },
            { "I kept on living, hell I even got sick from the Virulent, yet I was Gothivia's last person to get healed from her. Rek eventually got infected too yet since havoc was electronic, he stayed normal. The creatures that lived the best were mostly metallic, its what remains of our old village.", "时间匆匆，不曾停留，我甚至也曾感染“瘴煞”，但最后歌瑟梵治愈了我.就算是雷克，最终也没有逃过被感染的命运，但由于浩劫龙械是机械的，它不会被感染.在我们古老村庄的遗迹中，生活得好的大多是金属生物." },
            { "After the last healing in from Gothivia, I'd say about 90% of our village was wiped out from the Virulent, our soliders, our love, and will to live all started to fall apart. ", "虽然最后瘟疫被歌瑟梵治愈了，但是我们村庄大约有90%的人被“瘴煞”瘟疫夺去了生命.瘟疫之后，我们的军队、对生活的热爱、和生活的意志都开始慢慢瓦解." },
            { "I could recall me laying on a bed as I watched our city crumble, Irradia would stay by my side and we'd comfort each other as the world caved in for us.", "我现在还记得当时自己躺在床上，伊瑞蒂安就陪在我身边，我们一起看着我们的城市一点点走向破败，一起互相安慰." },
            { "After a while of our suffering in the city Gothivia would leave to seek vengence and power to save her sister, leaving Irradia to be at the helm. Take a guess who arrived not so soon afterwards? Fenix, she came to take what was left of us.", "在我们城市遭受瘟疫一段时间后，歌赫梵离开了城市去追寻力量来拯救薇莉亚与复仇，留下了伊瑞蒂安来管理整个城市.你猜猜谁不久之后谁来了？是凤涅克绯琦这个恶魔！她来摧毁了我们剩下的一切." },
            { "Fenix is like a scouraging raven looking for its next feast, and we were on the menu. I was forced to split from my love due to her sacrifices of being a leader. We haven't seen each other since, yet I know she's out there somewhere. No way would she loose to Fenix..", "绯琦就像一只猎食的秃鹫，而我们则是她的食物.伊瑞蒂安践行了作为领袖的责任，她牺牲自己吸引绯琦，我被迫与她分开.从那以后我再也没有见过她，但我知道我在某处一定能找到她.她是绝不会输给绯琦的..." },
            { "The Great Departure, that's what I call the leaving from what was left in our city. As the Carian army approached, we hid through underground tunnels to escape, some of us, including me, haven't gone back to the surface. I was even invited to come to the Fable.", "“大迁徙”，这就是我对逃离我们城市进行远行的称呼.随着卡利亚军队的逼近，我们通过地下隧道躲避，包括我在内的一些人，再也没有回到地面.我甚至被邀请过前往“古谕遗境”." },
            { "Those who made it to the surface from the Great Departure reinvented the Harboring Morrow yet from all the messages from BORDOC, it isn't the same. They close their doors to everyone in fear and they look for Gothivia, she never said where she went.", "那些在“大迁徙”中成功到达地面的人重建了“幽曦城堡”，但从波尔杜克的消息来看，“幽曦城堡”已经不再是原来的“幽曦城堡”了.居民出于恐惧对所有人关闭了城门，并且他们在寻找歌赫梵，但是歌赫梵从未说过她去了哪里，因此寻找起来犹如大海捞针." },
            { "I was in tunnels underground for 10 of my years, now I lay here with all the corpses and electronics that I bear, I've travelled every part of this world except the surface, to ever find Fenix again would send me over my limit.", "我在地下隧道里待了10年，现在我和我所携带的所有物品与电子设备都在这里.为了寻找伊瑞蒂安，我走遍了这个世界除地面的每个角落.我现在已经力不从心了，如果再次遇到绯琦，我就只能接受天命引颈受戮了吧" },
            { "You know, maybe I should have travelled with the rest of the members of the morrow, many of us split up in our escape, many died, hell, maybe I'm the only standing survivor, but I'm here.", "你知道吗，或许我应该和幽曦城堡的其他成员一起逃亡，在我们逃跑时很多人分开了，很多人死了，见鬼，我或许是唯一的幸存者，但我却在这里独自苟活." },
            { "My creations that I make now are from my explorations, I will find Irradia again, I need to apologize, to say something. These are all for her anyway. If only I could have stopped this from getting this way, maybe I could have stayed against her will.", "我现在创作的作品都来自于我的探索，我会再次找到伊瑞蒂安，我会说些什么向她道歉.如果我当初能阻止这一切发生，我会不顾她的意愿留下来." },
            { "Of all my years to live and ever to live, I will never understand things like Fenix, her torturous additude, why she went to such lengths to kill us, why the infection was so hard to fend off, and why I couldn't stay, these are all for you, Irradia. ", "在我过去和未来的所有年岁里，我永远无法理解像绯琦这样的人.她折磨人的态度，她为什么要费尽心思杀死我们，为什么瘟疫如此难以抵挡，以及为什么我不能留下来，这些都是为了你，伊瑞蒂安." },
        });
        #endregion
        #region Gambit 赌徒
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetBestiary), new() {
            { "She loves those ruin medals huh?, so much so that she is now attracted to you :(", "她太喜欢那些遗迹勋章了！以至于她已经对你生出了感情 :(" },
            { "Zielie the Gambit", "赌徒泽丽" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.GetChat), new() {
            { "I love the party girl! Shes really sweet! Umm could you maybe hook us up :(", "我太喜欢派对女孩啦！她又善良又有趣！你觉得你能不能...给我们互相介绍一下？" },
            { "Hii, it is a me, Zielie! I'm frantic at moments but what can you expect when your in a world full of death and loooove?", "嗨~，我叫泽丽！我有时会有点神经质，但在一个充满爱与死亡的世界中这样不是最好了吗！！" },
            { "Ive heard that the morrow is very pretty, I talked to veribloom and she said her society is falling apart though so maybe not.", "听说幽曦之地很漂亮，但我问薇绿的时候她说那里的社会已经快要完全失控了，我还是先不去那里了为妙." },
            { "I have some things on the market for you, I go around collecting items and I get more stuff when you beat bosses and honestly, you seem really cool! :0", "我这里有点好东西卖给你！都是我自己捡来的和你打Boss剩下的东西~你也很棒哟！" },
            { "You know who is responsible for your dice rolling righttt? You know, uh after you beat bosses? Yeah, thats me ya silly lovebug", "哎，你知道你的赌博骰子都是谁在扔对吧？就是我呀你个小傻瓜." },
            { "Can we get married?", "咱们来结个婚，你意下如何？" },
            { "Soo are we gonna get married or are you gonna buy something?", "买点东西吧！难不成~你想把自己卖给我？" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Zielie", "Zielie" },
            { "Zemmie", "Zemmie" },
            { "Zeilie", "Zielie" },
            { "Zielie", "Zielie" },
            { "Wenomechinimasama", "Wenomechinimasama" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetChatButtons), new() {
            { "Marry", "求婚！" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.OnChatButtonClicked), new() {
            { "OMG YOU DOOOO? Aww youre so sweet \nwe can hold off until a bit later :3", "天哪你答应了？？？！！！当然啦甜心~\n但我们还是可以再等一会的吧:3" },
            { "Aww cmon, don't be so silly, \nlets wait until we fix this world, \nlet me help you out :P", "小傻瓜~\n等这个世界的问题解决了再说吧.\n让我来帮帮你！" },
            { "Awaaaaaaaaaaaaaaaaaaaaaaaa~ \n(Zielie is too flustered to continue)", "哇啊啊啊啊啊啊啊啊啊啊~\n（泽丽激动到语无伦次）" },
        });
        #endregion
        #region Gia 吉娅
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetBestiary), new() {
            { "Wow you done messed up this time with the Virulent spill huh.", "看看这瘴煞的势头，你这次可真惹上大麻烦了." },
            { "Gia the Scientist", "研究员吉娅" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "她有那么多超棒的机械！我好想要啊." },
            { "A long time ago, I used to experiment with Biotech. It went wrong, and teleported pieces of itself all over the world. You might have found some by now.", "很久之前我还在研究生物科技，但是那件作品出了岔子，残片飞散到了世界各处.你可能已经找到了其中的几片." },
            { "Maybe if you find some of my lost tech, you could craft my original biotech and retry my experiments!", "如果你能找到那些我遗失的科技零件，就能造出我的独创机器，重试我的试验！" },
            { "The guide seems to know too much for a human being. I feel like he has something else connected to him…", "向导知道的实在太多了，他真的只是个人类吗？我感觉有什么其它东西与他有联系..." },
            { "The merchant keeps telling me about this dangerous eye thing. I could just zap it with my Bio laser.", "商人一直在说什么危险的大眼球...它要是敢来，我就让它尝尝我的反生物激光." },
            { "Aimacra seems pretty neat, too bad she's taken", "安魅凯拉看起来不错，可惜她已经有伴了." },
            { "I wouldn't mind hooking up with the Steampunker :)", "蒸汽朋克人也不赖嘛，我想和她试试：）" },
            { "So many spare parts and materials, bring them all to me!", "有多少零件材料就给我拿来多少！" },
            { "I can't believe I let it get loose, I've complicated too many things.", "真不敢相信我居然一时疏忽把“它”放出来了...这下事情复杂了好多." },
            { "Can you go collect some runes for me? I'd love for you to get working.", "给我收集一些符文碎片吧！反正你闲着也是闲着." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.SetNPCNameList), new() {
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
            { "Gia", "Gia" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetChatButtons), new() {
            { "Trade Rune", "交付符文" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.OnChatButtonClicked), new() {
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" }, // 勿动, 下同
            { "I give you my thanks for this Desert artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },

            // 这里应该是 Ice artifact, 但是笨笨作者复制粘贴时忘改了, 导致只能使用 InOrder 的方式改
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Overworld artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Ocean artifact, I'll research it greatly, heres something in return..", "感谢你帮我找到了这块符文，我会仔细研究它的.这是些回礼，难表谢意..." },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Jungle artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
        });
        #endregion
        #region Ginztel 玄铁军官
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.SetBestiary), new() {
            { "Dumbfounded by your strength, the commander retired and came to your base for a visit and a free hotel.", "这名已退休的玄铁军官被你的力量大为震惊，他决定来看看...以及蹭个住处." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ginztel), nameof(Ginztel.SetNPCNameList), new() {
            { "Gintzia", "Gintzia" },
            { "Ginztel", "Ginztel" },
            { "Steven Universe", "Steven Universe" },
            { "Gintzel", "Gintzel" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.GetChat), new() {
            { "Hehe the Demonilitionist guy is pretty cool, he's got bombs..", "嘿嘿，那个爆破专家不错，他有好多炸弹..." },
            { "Im just peeping around, I might stay for a while..", "俺只是来看看...或者在这住一小会." },
            { "My team was quite weak to say, I apologize for the inconvience", "俺的那帮人好弱啊.真是给你添麻烦了." },
            { "Some of the things I'm selling are from base, we've all taken quite a liking to you all.", "俺卖的东西好多都是是从俺们基地拿来的！俺们都觉得你还是个不错的家伙！" },
            { "If you can kill Gothivia for us we can scavange and steal their items, please help us do that", "如果歌瑟梵挂了俺们就能抢她的东西啦！你一定要赢啊！" },
            { "We may be weak but we still give all of our little praise to Verlia, hence why we stole from her sister..", "俺们不强，但俺们最稀罕薇莉娅，才敢偷她姐姐的东西." },
            { "Could you murder Gothivia in the most brutal fashion possible? She is way too dauntless and carefree, we hate her and she took our home..", "你一定要把歌瑟梵狠狠的揍一顿呀！俺们看着她那副目中无人的表情就来气！她还霸占了俺们的家..." },
        });
        #endregion
        #region Ishtar 狂渊
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ishtar), nameof(Ishtar.SetBestiary), new() {
            { "Entrance", "狂渊入口" },
            { "The entrance to the Ishtar Citadel", "狂渊的入口" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ishtar), nameof(Ishtar.SetNPCNameList), new() {
            { "Ishtar Pin location", "狂渊" },
            { "Ishtar Pin location", "狂渊" },
        });
        #endregion
        #region Mardenth 玛登斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetBestiary), new() {
            { "One of the 3 Children of Daeden, this one being the most useless", "达登的三个孩子里面，最弱小的一个" },
            { "Mardenth of the Veil", "天纱之玛登斯" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "她有那么多酷炫的装置，我喜欢它们！" },
            { "Damn that Sigfried guy.", "那个叫齐格飞的家伙真是该死啊" },
            { "Where's Ereshkigal?", "厄莉什基迦勒在哪" },
            { "Daedus, Jovhia, Daeden? Where'd you all go?", "代达斯，乔维亚, 达登?你们都去哪里了？" },
            { "I'm quite formiddable you see. I can destroy anything with my hands.", "你瞧，我相当可怕.我可以用我的双手摧毁一切." },
            { "I need to study up on my electric magic. If my dad wasn't dead he'd be proud of me. Gosh I wish you were here Daeden", "我需要进一步学习我的电系魔法.如果我父亲还活着，他一定会为我感到骄傲的.天哪，我真希望你能在这里，达登" },
            { "I never knew my mom..", "我从没见过我的母亲..." },
            { "Why is Jovhia always in the sky?", "为什么乔维亚总是在天上呢？" },
            { "Hey you, get out of here!", "嘿，你，滚出去！" },
            { "Scadabble you women harrasser.", "你这个骚扰女性的家伙！" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Mardenth), nameof(Mardenth.SetNPCNameList), new() {
            { "Mardenth", "玛登斯" },
            { "Mardenth", "玛登斯" },
            { "Mardenth", "玛登斯" },
            { "Mardenth", "玛登斯" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetChatButtons), new() {
            { "Talk", "闲聊" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.OnChatButtonClicked), new() {
            { "Heheheh, I like to eat little wormy guys but they won't stop squiggling. Reminds me of when our dad Daeden left us. ", "呵呵呵，我喜欢吃那些小虫子，但它们总是不停地扭动.这让我想起了我们父亲达登离开我们的时候." },
            { "Where did Daedus go?  He left us so long ago. I hope he wasn't swayed by that Harlet Gothivia. She seemed power obsessed and hungry. Maybe that's just me though", "代达斯去哪了？他很久以前就离开我们了.我希望他没有被歌瑟梵影响.她似乎对权力着迷并且渴望权力.也许这只是我这么觉得吧." },
            { "I might be the only one but, Ereshkigal is kind of hot isn't she? Hell you wouldn't even know would you. You're taste in women is flat.", "或许只有我一个人觉得，但是厄莉什基迦勒确实有些性感，不是吗？什么，你说你不知道？！不是？哥们！你对女人的品味也太差了吧！" },
            { "You don't understand how we are. We're higher than all below us, which is everyone except a god. Only they can be held to such high status. Squirm off you worm.", "你不会明白我们是怎样的存在.我们比除了神之外的所有人都高贵.只有神才能拥有如此高的地位.爬吧，你这虫豸." },
            { "I wish Sigfried didn't go insane. He's such an asshole, even our dear Ereshkigal left with him to seal him away...  ", "我希望齐格飞没有发疯.他真是个混蛋，就连我们亲爱的厄莉什基迦勒也离开我们去封印他了……" },
            { "Maybe I may be the only person to question the gene pools of these people. Like where do they all look so pretty from??? Im wearing this mask cuz I look like a goblin.", "也许我是唯一一个质疑这些人基因的人.比如他们都是从哪里遗传来的美貌？？？我之所以戴着这个面具，是因为我长得像哥布林一样..." },
            { "I want a beach episode with Zui and Ereshkigal now! ", "我现在就想看到蕊和厄莉什基迦勒的海滩写真集！" },
            { "I would want to be more powerful but that takes a lot of training. Anyone who dares to take more than what they are given should be punished. ", "我想要变得更强大，但这需要大量的训练.任何敢于索取超出所给予的人都应该受到惩罚." },
            { "Those guys in the well? They are trapped down there because they made some goofy deals in their lives to get more power and just like the great Veil people we are, we trapped them away for good.", "那些在井里的人？他们被困在那里，因为他们在生活中做了一些愚蠢的交易来获得更多的力量，就像我们这些伟大的天纱人一样，我们永远地困住了他们." },
            { "I don't know what the outside world is like.", "我不知道外面的世界是什么样子的." },
        });
        #endregion
        #region Merena 梅瑞娜
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), nameof(Merena.SetBestiary), new() {
            { "Magic Magic MAGIC", "魔法，魔法，还有更多魔法！" },
            { "Merena the bewitched sorcerer", "着迷术士梅瑞娜" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), nameof(Merena.GetChat), new() {
            { "Funny enough the clothier used to come through here all the time for some of our amazing fabrics", "说起来，服装商经常来这里买我们的魔法丝绸和布." },
            { "I wonder what my sister Sylia is up to nowadays, do you know her?", "你最近有见过一个叫赛利亚的人吗？她跑哪去了..." },
            { "I'm gonna be the very best, like no one ever was... ", "我要成为史上最强的魔法师！" },
            { "Fenix is the best queen there will ever be! She gives us all what we want :P", "绯琦真是理想中的皇后！她给了我们一切！" },
            { "This place is so calming, I can't stand it but I would give everything to be near Fenix", "这地方太安静了，我不喜欢，但能够站在绯琦身边，这点小事不算什么." },
            { "Aimacra seems pretty cool, she came here recently looking for some brooches", "安魅凯拉很棒哎.她最近来这里寻找饰符来着." },
            { "Hey uh could you do something for me? I have a little favor, just ask what it is!", "呃..你能稍微帮我个忙吗？会有回报的！" },
            { "I've always wanted to be the best witch there is! I've always been outshined by exiles though, including my sisters sadly.", "我一生的梦想就是成为最强的女巫！但我总是被人超越，尤其是我的姐妹." },
            { "I really need to beat my sister in a battle someday.", "哪天我见到她了，一定要当场打败她！" },
            { "It's strange, the economic system here is almost like communism", "奇怪，这里的经济怎么这么像...共产主义？" },
            { "Damn we have some cool shit here", "这里的东西都好棒啊！" },
            { "No doubt about it but Fenix is truly the strongest witch in all of the lands, maybe even more powerful than the witch of light in the hallow, I don't like her.", "毫无争议，绯琦才是这片大陆上最强的女巫.可能比神圣的光之巫女还强.我恨那家伙." },
            { "Hahh, I remember that goon Verlia, she's kind of dumb but shes at least powerful, I remember she got exiled for stealing tomes, I might need that from her.", "哈，我还记得那个薇莉娅.脑袋一根筋，但力量还挺强.她因为从皇都偷了魔法书而被流放.我可能还需要那本书." },
            { "Can you go collect some runes for me? I'd love for you to get working.", "呃..你能稍微帮我个忙吗？会有回报的！" },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(Merena), nameof(Merena.SetNPCNameList), new() {
            { "Merena the Sorcerer", "术士梅瑞娜" },
            { "Merena the Sorcerer", "术士梅瑞娜" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), nameof(Merena.SetChatButtons), new() {
            { "Merenas Quest", "任务" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_VerliaStart", new() {
            { "What are you standing there for, go kill Verlia! She's an enemy of the royal capital and she has a book I need lmao", "别光站着，去干掉薇莉娅！她从皇都偷了一本书，我需要！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_VerliaComplete", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "哇，谢了！接下来我想要幽曦村落里的一个特殊球体，那里面蕴藏着世间独一无二的魔法，我想好好研究一下它到底是怎么形成的，而且这本书里也提到了需要它." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MorrowStart", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "哇，谢了！接下来我想要幽曦村落里的一个特殊球体，那里面蕴藏着世间独一无二的魔法，我想好好研究一下它到底是怎么形成的，而且这本书里也提到了需要它." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MorrowComplete", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "哇哦~看看这精美的橙色条纹，看看从这里流出的魔力！你居然真的把它搞到手了！非常感谢！接下来拿给我100个粉尘袋就好了，是酿造药水用的." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_DustBagsStart", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "哇哦~看看这精美的橙色条纹，看看从这里流出的魔力！你居然真的把它搞到手了！非常感谢！接下来拿给我100个粉尘袋就好了，是酿造药水用的." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_DustBagsComplete", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "好样的，这对你来说没什么难度吧？接下来我需要一些含有魔法的纸张.困难模式各地都出现了特别的怪物，从它们身上收集材料.去吧！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MagicPaperStart", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "好样的，这对你来说没什么难度吧？接下来我需要一些含有魔法的纸张.困难模式各地都出现了特别的怪物，从它们身上收集材料.去吧！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_MagicPaperComplete", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abyss. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "哦哦哦太棒了！还有最后一件事想要拜托你.传说，古时候有个贼偷了一本极其重要的古籍，并藏在无尽深渊之下.你能去找找它是不是真的存在吗？无论花多久都是值得的..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_TomeStart", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abysm. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "哦哦哦太棒了！还有最后一件事想要拜托你.传说，古时候有个贼偷了一本极其重要的古籍，并藏在无尽深渊之下.你能去找找它是不是真的存在吗？无论花多久都是值得的..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "Quest_TomeComplete", new() {
            { "THANK YOU THANK YOU THANK YOU, omg this is the best day of my life! I never knew this actually existed! Were the rumors true??! dsfjhnbhfribdhs- Nevermind who cares anymore, we can both be the best mages ever! I open my shop to you and here, a token of my graditude. ", "我的天呐！！！我一生都在等这一天！！它居然真的存在！那些故事都是真的...哇哇哇哇哇——谁还管那些啊！我们一起来做世界上最厉害的魔法师吧！！感激不尽，我会把我有的一切都卖给你！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Merena), "StartQuests", new() {
            { "Hey, I have nothing else for you to do! Thanks for all of your help, have you checked out my shop yet?", "感谢你，我心愿已了！来看看我的商店吧！" },
        });

        // 主要用于商店注册, 如果同时启用 Shop Expand 能在查询商店时看到汉化效果
        Dictionary<string, string> merenaQuestSystemConditionLocalizations = new() {
            { "KillVerlia", "需要击败薇莉娅" },
            { "ExploreMorrowedVillage", "需要探索古谕村落" },
            { "Give100DustBags", "需要上交 100 个粉尘袋" },
            { "MakeMagicPaper", "需要制作魔法纸张" },
            { "Tome", "需要制作终极魔导书" }, // MakeTomeOfInfiniteSorceryCompleted
        };
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionKillVerlia", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionExploreMorrowedVillage", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionGive100DustBags", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionMakeMagicPaper", merenaQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.MerenaQuestSystem", "get_ShopConditionTome", merenaQuestSystemConditionLocalizations);
        #endregion
        #region NaturalWitch 自然女巫
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetBestiary), new() {
           { "Steaming from the depths", "地下深处的火焰与浓烟" },
           { "Ordin, The New Monarch", "星树新君奥丁" },
       });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.GetChat), new() {
           { "Shes got some great cogs", "此女身怀绝技，机巧非凡" },
           { "Remove yourself from my sight", "速速退出吾之视线！" },
           { "You walk like an infant with no tucas", "汝行步蹒跚，犹如初生之犊未谙世故" },
           { "What a pitiful endearment, praise to the ones above.", "何其微薄之宠爱，竟上达天听" },
           { "...", "..." },
           { "You are not fit to become a god", "尔非神格之材，何足论天地主宰" },
           { "Oh Sigfried, return in good health or I shall slay you with my own hands from such a succubus!", "齐格飞，汝必全躯而返，否则吾将亲往，以吾之手，将汝从那妖妇之爪中解脱！" },
           { "Bring me their Manifestations", "将彼等之具现体，悉数呈于吾前" },
       });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ordin), nameof(Ordin.SetNPCNameList), new() {
           { "Ordin, Illurian Monarch", "星树之君奥丁" },
           { "Ordin, Illurian Monarch", "星树之君奥丁" },
       });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetChatButtons), new() {
           { "Reminisce of Sigfried", "回想齐格飞" },
       });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.OnChatButtonClicked), new() {
           { "Thy is so resilient, unhand me from these this trecherous nagging and take this for thy shall not be astute to your prescence no longer.", "汝之纠缠，已至厌烦.收下此物，速速离去，莫再扰吾安宁，汝之行径，实难容忍" },
           { "To be one of the forth or forward, the lands that I rest in reek of falsification of hypocrisy and power.", "欲居人先，而吾所驻之地，充斥伪善与权力之虚饰" },
           { "Sigfried was once a young fellow, thy brother in one's eye's and a villian in anothers'.", "昔日齐格飞亦是少年郎，于汝眼中似兄弟，于他人则如恶徒" },
           { "Our sacred castle falls ill to such burning. Our wishes have been grafted under the curse of Sigfried's unveiling.", "吾等圣堡，竟罹此焚劫.吾心所愿，悉于齐格飞揭咒之下，已非昔比" },
           { "Fall away, dear brother ", "汝且安卧于斯，余生休再相见" },
           { "Mark thy words with caution. Ereshkigal is a loveless harlet who took the life of the brother of many. Yet thy fulfills their prophecy among lovers, hence she is not a false goddess.", "慎尔言辞.厄莉什基迦勒，痴恋之狂渊巫女也，夺多兄之命.然其于恋人中预言成真，故非伪神" },
           { "All our goals are put to rest following the lands of the veil. Finish all those who have wronged our beloved world.", "吾等宏图，随天纱之土而偃息.凡逆吾心爱之世者，必尽数了断" },
           { "Manifest their souls and bring them to my company. You shall be rewarded until the rekoning begs for your place to be silenced. ", "昭其灵魄，引之吾侧.厚赏于尔，迨天命缄默" },
           { "Niivi, the protector of the lands of the veil, yet curse all upon thy brother to be selfish and steal among those of power and wealth. He was greedy and in his expense payed the lovers' prison.", "尼伊维，天纱之域守护者，竟诅咒汝兄，令其于权财中独占且窃.贪婪之行，致恋人陷囹圄" },
           { "Now I sit ill waiting for the lands of the veil to change.", "今吾抱恙而坐，静待天纱之域变迁" },
       });
        #endregion
        #region PULSARHOLE 脉 冲 黑 洞
        // 暂无需要强制本地化的内容
        #endregion
        #region Sirestias 希丝忒莉亚
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetBestiary), new() {
            { "Your eternal bonding with this individual resonates with everyone throughout!", "你与这位存在之间永恒的羁绊回荡不绝..." },
            { "Sirestias", "希丝忒莉亚" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.GetChat), new() {
            { "Here to give me some company I see?", "哦？来陪陪我吗？" },
            { "Hmph how's Aimacra doing? Nevermind I already know that answer.", "嗯，安魅凯拉怎么样了？算了，我又不是不知道." },
            { "Enjoying yourself?", "玩的还开心吗？" },
            { "Sometimes I forget you're bounded with me always", "我都快忘了你和我已经绑定在一起." },
            { "Its always sweet to see you do things for me", "你愿意为我做事，我真是欣慰啊." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Sirestias), nameof(Sirestias.SetNPCNameList), new() {
            { "Sirestias", "希丝忒莉亚" },
            { "Sirestias", "希丝忒莉亚" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetChatButtons), new() {
            { "What do I do next?", "接下来做什么？" },
            { "Give Completion Idol", "给予陨神之像" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.OnChatButtonClicked), new() {
            { "Kill the stone guardian, commander gintzia will soon raid you with his army of failed troops from the govheil. He will be very easy so take him swiftly and beat him into submission hun. ", "击败那个守卫之后，金戈亚指挥官很快就会从歌维赫堡率军入侵.他就是个软柿子，速战速决，把他打趴下！" },
            { " I'd recommend going into the Fabled Swamp over to the right or collecting resources to get ready to fight either Jack or find a sun alter in a desert and prepare for Sunstalker! Zui may be a good person to talk to in the witch village for quest items too :) ", "我推荐去古谕之地探索，或者收集材料挑战南瓜杰克或者猎日游隼.如果你想干些别的，去左边的女巫村落找蕊吧，她有事情要拜托你." },
            { "Nice babe, I want you to go kill Jack in the Fabled swamp on the right then, you need a wandering essence and he shouldn't be too difficult. ", "好样的宝贝.接下来去右边的古谕沼泽干掉南瓜杰克吧.他不是很强，只要有漂浪焰华就能把他召唤出来." },
            { "Nice work! I want you to go headhunt a bird in the desert, his name is Sunstalker and they are a bit challenging but less so than the last, collect some mandibles in the desert to make the Sun stone! Find the alter on the surface of a desert!", "干得好！是时候去沙漠里打鸟了.它叫“猎日游隼”，有些挑战性，但不太多.用蚁狮上颚做出它的召唤物，在沙漠地表找到它的祭坛！" },
            { "You're next target is Daedus, he's a strong one. Hes a very loyal Guardian to one of the biggest threats here being Gothivia, we need him gone to get to the big fish in the sea. For some reason he holds some power of a singularity so beware. He resides low in the temple in the Fabled Swamp, no extra preperation needed.", "下一个目标，守护者代达斯.他力量不凡，是歌瑟梵的尽忠护卫，也就是说，是钓上这条大鱼的重要一环.他拥有一颗奇点的力量，小心！他目前沉睡于古谕地下，不需要做什么额外措施就可以去挑战." },
            { "Oh my gosh nice, so here's where things are going to get difficult. If a blood moon happens we need to exterminate Dreadmire, she spawns after killing a blood cyst during a blood moon, you can also get some terror fragments too! She'll pose too much of a threat if we let her live. She's I think one of the three sisters, formally known as cozmire. She needs to die and after that I'll give some great rewards.", "好嘞，接下来的任务可能有些难度了.如果血月发生，我们需要抓住机会干掉绛渊恶巫.打破血肉囊或者收集恐惧残片来召唤她.她是天纱三姐妹之一，曾经被称作“天寰神巫”，留她活着风险太大.如果干成，奖励自然会有的." },
            { "We are making big progress now! I don't know if you have been killing other ravenous monsters but I'd recommend doing so as the next one on our list is Verlia but to get to her we have quite a few things to do first. Make yourself a void key and find a temple deep in the ice biome, there should be some loot and hopefully an alter that'll give you a lantern. She was trapped by Fenix but she needs to die so we can bring out Gothivia.", "我们的计划正大步前进！我不清楚你最近又干掉了哪些怪物，但是时候干正事了.名单上的下一位是薇莉娅.在见到她之前还有不少事情要完成.去弄到一把虚空钥匙，在冰雪地下的神殿中有不少东西等着你.找到祭坛，击败那个守卫，拿到提灯.薇莉娅的灵魂被绯琦囚禁在那里面，但我们需要让她彻底死掉，来引出歌瑟梵." },
            { "Ok you got the lantern! Go to the cathedral overtop the ice biome and summon her at the top at night. This will be our biggest foe yet but I know you can kill her, sorry Aimacra is tired of being my assasin so it's your turn.", "OK，你拿到那盏灯了！等到晚上去到冰雪地圣殿的顶端释放她.这是直到如今我们最大的挑战，但我相信你的能力.抱歉，安魅凯拉不想再被我当刺客使唤了，这次轮到你上了！" },
            { "Oh damn this is great. I think that completes our list for now, check back in with me in Hardmode! We'll purify this world of all danger and create peace and then we can be together and move on. Thank you again.", "哦天，这也太棒了！我们现阶段的任务全都完成了！等到你打败了血肉墙再来找我吧！我们一定能净化这个世界上的一切威胁，一起向前.感谢你的付出." },
            { "Welp here we go again. So theres a strange issue we have, so Daedus isn't the only barrier to trying to stop us from getting to Gothivia, Aimacra just went and explored around and found some new places and there was this castle underground in a green biome? I noticed Gothivia's marks on it and the Sun hasnt started turning green, could you look at that? There should be some catacombs underground in the desert, ocean and caverns to help power up too.", "哟，又见面了.我发现了个问题，代达斯并不是歌瑟梵筑起的唯一一道障碍.安魅凯拉刚在那个绿油油的地方地下找到了一座城堡，上面有歌瑟梵的印记，你能去看看吗？至少太阳还没变绿，说明我们还有时间.还有，沙漠地下，海洋里，洞穴中存在着三座墓穴，里面的东西应该会帮到你." },
            { "There was a person down there claiming to be Gothiva? Thats strange. Gothivia seems to be making an appearance on the world. Apparently things are changing the skies and things are falling from them, Beware of STARBOMBERS, Aimacra warned me that they were manufactured here as well as Ekrose and you have experience with them.", "那边有个人在假装歌瑟梵？奇怪.歌瑟梵本人貌似也正在赶回这个世界.再者，这个世界的天空好像出现了些异变，掉下奇怪的东西.小心 星爆者，安魅凯拉告诉我它们在这里也有被制造，和在艾科洛斯一样." },
            { "I didn't think Rosemary's creations would've made it here. Ekrose sure does have an affect on this world. I saw some strange disturbance on the left side of the underworld though, can you check that out? I went to talk to Veldris and he told me Sylia may be up to some demonic magic that could ruin our process, so killing her is a good option. ", "我之前还觉得迷迭香城的造物不会出现在这里呢.看来艾科洛斯和这个世界确实有一定联系.我感受到地狱的左侧有个奇异的能量扰动，维尔德斯告诉我那可能是赛莉亚搞的鬼，她的黑暗魔法可能会阻碍我们，我们要先发制人把她除掉." },
            { "It was a void witch... Interesting. Must be related to that Merena person Aimacra talked about. I haven't been to the Royal Capital much, mainly because it's so far out but maybe we should kill the Queen there, she is definitely extremely powerful but I don't really know how to talk to her, I haven't seen her yet. If you can could you go kill her for us? ", "虚空女巫...真有意思.应该和安魅凯拉说的那个梅瑞娜有点关系.我没怎么去过皇室首都，那里太远，但那个女王也在我们的名单上.她的力量很强，而且我没和她沟通过.要不你去把她干掉？" },
            { "Ereshkigal huh? I think I know her, she also isn't supposed to be here. However she got lost I guess we can give her some sense", "厄莉什基迦勒？我知道这个名字.她也不应该出现在这里的.如果她是迷路了，我们也许可以帮帮她？" },
            { "Weheeee! You're doing so well! I can like get off to this! I'm kidding :(. Maybe you can try and explore around some more. We need to prepare for moonlord!", "哇呜！你也太高效了！我要不要直接让你接手整个计划呢...开玩笑的啦.接下来你就自由探索吧，好好准备迎战月球领主." },
            { "I did not expect you to want to kill her honestly. I went and explored around and she seemed nice. Wait you didn't kill her? Oh dang, well she isn't on our list anyway so it's fine lmao. She isn't causing us any issues.", "我真没想到你去打她...我在四处转悠的时候遇见了她，感觉她还不错的.你说你没杀了她？也好，反正她也不在我们的名单上，也没给我们添乱." },
            { "Ok ok we got some good stuff done. Time for Gothivia as she's not particularly the worst but she keeps inspiring bad people to do ad things and we need to teach her not to do that.", "干得不错.是时候去找歌瑟梵了.凭心而论她并不坏，但她的领导力总能激励坏人去干坏事，我们就给她一个教训，让她停止这样." },
            { "Maybe we shouldn't have killed her, I don't know if there was a reason to kill Niivi. You just wanted weapons and gear? I mean if it helps I guess. She was doing more good than harm", "我本来没想杀她的，我们没有理由对尼伊维下手.你想要装备？要是有帮助的话，那好吧，但她可没有做任何恶事." },
            { "Okie dokie, Gothivia has agree to stay calm so we aren't going to assassinate her anymore, I feel bad for killing her sister now. I hope Vixyl doesn't find out.", "好好，歌瑟梵答应暂时保持冷静，我们应该不用刺杀她了.我现在对杀了她的姐妹感到有些抱歉...希望维西尔不会发现吧." },
            { "YESSS, we're getting closer to our goals!! Aren't you excited <3", "好耶！！我们距离目标又进了一步！你不觉得激动吗？<3" },
            { "I couldnt find anything more so I'll give you an extra token!", "我也没找到什么更好的东西，所以多给你一颗宝珠吧！" },
            { "Please go do something for me, we don't have all day you know ;P", "去做些我规划的事吧，咱们的时间可不多啊." },

        });
        #endregion
        #region UnknownSignal 神秘信号源
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetBestiary), new() {
            { "An Unknown Signal", "一个未知的信号从这里发出" },
            { "Unknown Signal", "神秘信号源" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.GetChat), new() {
            { "A static voice confirms the identity of the user, you are in the right place.", "一个模糊的声音确认了你的身份.看来这里是对的." },
            { "A static voice confirms the identity of the user, you are in the right place.", "一个模糊的声音确认了你的身份.看来这里是对的." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetChatButtons), new() {
            { "Touch Unknown Circuitry", "触碰" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetNPCNameList), new() {
            { "Unknown Signal Source", "神秘信号源" },
            { "Unknown Signal Source", "神秘信号源" },
        });
        #endregion
        #region Veldris 维尔迪斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.SetBestiary), new() {
            { "Freezing to death", "冰寒刺骨" },
            { "Veldris the assassin", "刺客维尔迪斯" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.GetChat), new() {
            { "Shes got some great cogs", "她的零件不错" },
            { "Who's next on this list to kill?", "下一个杀谁？" },
            { "How are you doing? ", "近来如何？" },
            { "I need to gamble a bit more today", "一会我还得再去赌几局." },
            { "That Sirestias woman creeps me out.", "那个希丝忒莉亚真的很吓人" },
            { "I gotta get to the Royal Capital some day. Maybe they can empower my weapons.", "哪天我一定要去一趟皇都.他们应该能让我的武器更强" },
            { "So coldddd", "好冷——" },
            { "Hey you, come buy some stuff from me!", "嘿，你！过来买点东西！" },
            { "Im starting to warm up this winter", "冬天也不那么冷了" },
            { "Everyone and all this damn god talk, it makes me crazy", "所有人都在说什么乱七八糟的神，快把我逼疯了" },
            { "Interestingly, I don't know why those sisters all are disconnected, it seems like they're always hiding something", "我完全不懂那些姐妹们为什么都不彼此联系.难道她们有什么不可告人的秘密？" },
            { "I wish I was someone important", "我要是个重要人物该多好啊" },
            { "Sometimes I wanna lead an army you know? I just wanna see Veiizal again", "有的时候我也想带着一支军队四处征战，但我只是想再见见维依佐" },
            { "You gonna buy something lad?", "需要什么吗，小伙子？" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetNPCNameList), new() {
            { "Veldris the Calm Assassin", "沉静刺客维尔迪斯" },
            { "Veldris the Calm Assassin", "沉静刺客维尔迪斯" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetChatButtons), new() {
            { "Talk", "闲聊" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.OnChatButtonClicked), new() {
            { "You doing good? I mean it's a hellhole out here. Sometimes I even start to wonder what brings you here. I'm just some lonesome seller, just be sure not to get on someone's deadlist or else I'll be seeing ya. ", "近来如何啊？外面都乱成一锅粥了，得亏你还想来.我？我就是个卖杂货的而已.只要你别惹上什么大人物，咱们应该不会有刀剑相向的那一天." },
            { "Everytime I hear someone talk about gods I want to just puke in their faces, like ew. I'm kind of glad that Sirestias woman is getting rid of them. Her and Fenix don't seem all too power driven. Fenix is just revenge driven, and I can respect that.", "每次我听到有人提那些神我都觉得不可忍受.希丝忒莉亚想要把它们全干掉我可太支持了.她和绯琦一样，都不是那种盲目追求力量的人.据我所知绯琦只是想要复仇，这我完全能理解." },
            { "If my weapons we're ever used, they better be in the right hands. My tools were crafted with some Luminull and some special metals, they better hold together- I had to steal some stuff from that Illuria place", "想要用我的武器，就小心点用，别把它们弄散架了.那可都是黯光和特殊合金做成的，为了造它们我特意去星树偷来的材料！" },
            { "I'm just gonna rant about this Illuria place honestly. WHY IS THERE A DRAGON JUST ROAMING. Like I thought those went extinct with the the virulent- oh I meant acid. I really just needed some scales but oh noo the watcher of society is there. ", "我真想好好吐槽一下那个星树.为什么那有条龙啊？而且她就那么若无其事地在闲逛！他们不是已经在瘴煞-酸蚀-那里被灭绝了吗？我想搞点鳞片，但一直有人看着..." },
            { "Back in my day building this house was my masterpiece, Fenix really gathered up an army just to build this cathedral here and that temple below just to trap some harlet who took her stuff. Down right evil though on Fenix's behalf, maybe overkill. ", "之前，这栋建筑可算得上是大师之作.然后绯琦集结了她的整支军队就为了建那座大殿堂来困住某位偷了她东西的婊子...要我说，纯纯的邪恶做法，而且太过了." },
            { "Some knights visited me the other day talking of this 'peace and formality' and I couldn't take it so I went to the Lunar tree, which for some reason they live on and I stole some fragments and some luminull? It seems pretty powerful and is probably related to Lumi in some way.", "前几天有几个骑士经过这里，一直说着什么“和平与礼仪”，我实在受不了他们的唠叨了，就去了星月巨树，他们居然住在那上面？我从那拿了些材料，感觉力量很强，说不定都和天纱琉明有联系." },
            { "I love myself commissions, just sayingg if you wanna commission me I'm all available, the last person I went to kill was some goofy guy named Rallad, some girl named Sylia asked me if I could do it for her since she didnt want to be seen, took forever to find him though. ", "有活干的时候最舒服了.你要是看谁不顺眼，就来找我吧.上一个给我委托的叫赛利亚，她让我去干掉一个叫瑞拉德的家伙，可找了我好一阵子." },
            { "Interestingly enough me and Sylia have fun sometimes, shes pretty nice once you get to know her, sadly she stays away from her sister Merena and the rest of the capital, she's pretty chill. Kind of wanna travel with her though. ", "我和赛利亚还算相处得来，只要你了解她，她还是很有趣的.她一直在回避皇都和她的姐妹梅瑞娜.之后有空的话我想和她一起去旅个游之类的." },
            { "The small joys of life comes from not having your house destroyed by some malevolent gods throwing down their trap cards when youre trying to sleep. It makes me annoyed when I have to peek out my window to make sure the black hole isn't going to hit my house.", "想象一下，你在屋里睡得好好的，某个神朝你这边扔了一张陷阱卡，整栋房子就毁了，很烦人对吧？我还得天天朝外看着，提防黑洞." },
            { "You knowww, I was named Veldris by my friend, I always grew up without a name since my parents died by a stupid raging black hole guy, name was Sepsis I believe? He killed off so much 30 years ago yet I remember it like yesterday.", "在我还小的时候，还没等到取名，我父母就被一个该死的疯子给害了，好像是叫...星烁.那是30年前的事，但我仍然记忆犹新.我现在这个名字还是一个朋友给取的." },
        });
        #endregion
        #region Zui 蕊
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), nameof(Zui.SetBestiary), new() {
            { "A traveller of the lands who may hold great power", "一名周游大陆的旅者，似乎掌握着强大的力量." },
            { "Zui the Traveller", "旅者 蕊" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), nameof(Zui.GetChat), new() {
            { "The dryad is pretty fun after all, she's pretty sweet and helps us with the gardening!", "树妖是个好人呀！她对我们都很友好，还帮我做些种花的杂务！" },
            { "We've had to kick a few witches out of this town you know, its quite a shame..", "我们之前不得不把几名女巫从这里赶了出去，真可惜啊..." },
            { "I keep going out to find more plants but somehow you're always here when I return. ", "我其实没有一直站在这里不动.只是碰巧每次你来我都在这里而已." },
            { "I'm trying to find a way to stop the corruption and virulent from spreading but I have no fix currently.", "我在想办法阻止邪恶地形和瘴煞之地的扩散，但目前为止我还没想出什么良策." },
            { "Hey love, you know you could be collecting stuff for me!", "如果你正闲着，去给我收集一些东西如何？" },
            { "Sirestias? Oh um yeahh we go pretty far back.", "希丝忒莉亚？啊...对...我和她有过一段交情." },
            { "Aimacra is cool too, this is my first time meeting her lol", "安魅凯拉也挺棒的，虽然我才认识她." },
            { "I wouldn't say I'm too powerful, afterall I a just a traveller", "我很强吗？不不不，我只是个旅者而已." },
            { "Sometimes I wonder what they did in Vodhome after we all left. I really have to catch up with Sirestias and the others.", "我在想，我们离开了那里之后，沃德府怎么样了.看来有必要去和她们叙叙旧了." },
            { "Are you here with Sirestias?", "你是和希丝忒莉亚一起来这里的吗？" },
            { "All these plants are so cool! I did just arrive here before Sirestias, there was some commotion and I think people here are trying to disrupt time and power.", "这里的植物太棒了！我比希丝忒莉亚早一小会来的，当时正赶上一片骚乱，好像是有人想要扰乱时间和能量." },
            { "Sirestias is a balancer, same goes for me but I like to just collect things.", "希丝忒莉亚的目标是“平衡”.其实我也一样，但我还是更喜欢干些悠闲一点的事，比如收集些植物." },
            { "Hey if you collect some items for me I can give you some stuff!", "帮我收集我想要的东西，我能给你奖励！" },
            { "Hey can you go collect for me?", "帮帮我嘛~" },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(Zui), nameof(Zui.SetNPCNameList), new() {
            { "Zui The Traveller", "旅者 蕊" },
            { "Zui The Traveller", "旅者 蕊" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), nameof(Zui.SetChatButtons), new() {
            { "Zui's Quests", "任务" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_NotCheckmarked", new() {
            { "Hi hii! Thanks for asking! Could you fetch me some plants, you can use this bag! Just fill it up with some different types of plants and I'll give you some stuff afterwards!", "嗨~谢谢你来帮我！给我收集一些植物之类的吧，就装在这个袋子里！我会给你回礼的！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_NotCheckmarkedHardmode", new() {
            { "Hehe I'm gonna up the difficulty of these, I'm gonna need some bigger plants, so you'll need to fill up this bag! Thanks!", "嘿嘿，接下来的任务有点难了哦.去给我找一些更加稀有的植物吧，装满这个袋子就行！感谢！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_1Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "好的，这些我就收下了，拿好你的奖励！能再给我收集一点吗？" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_16Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "好的，这些我就收下了，拿好你的奖励！能再给我收集一点吗？" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_3Complete", new() {
            { "Ok ok, 3 quests is kind of good, thanks for caring a lot about this! I've got more items in my shop for you, bring me 3 more and I'll get more for ya!", "完成3个任务了，棒哎！我在商店里给你准备了更多好东西！再来3个，还有更多惊喜！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_6Complete", new() {
            { "6 Quests is actually kind of crazy, I've opened up with a few more items for you if you want! Bring me 4 more ;p", "6个任务，疯狂！我又进了一批你可能想要的好东西！再给我收集4个吧 ;p" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_10Complete", new() {
            { "Damn, 10 quests? You're on a role you know! I've got some more items for you in my shop actually, I went travelling and Sirestias gave me a few items! I'll give you some more items if you can do 10 more!", "哎呀，10个任务完成了？你真是前所未有啊！正好前段时间我去找希丝忒莉亚，她给了我些东西我都放在商店里了，你看看吧.再做10个任务，还有好东西！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_20Complete", new() {
            { "You have finished 20 quests for me! Thank you! I've got more items in my shop because of it too! If you want more from me bring me ten more and maybe we can have some fun! ", "你完成了20个任务！万分感激！我的商店里又有新东西啦！还想要更多？再完成10个任务，就差不多到了咱们的玩乐时间啦！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "Quest_30Complete", new() {
            { "My graditude is of the utmost thanks, in return you can have anything in my shop! And I'll help you out personally sometime if you need me ;p ", "真是太太太感谢你了！我的商店完全对你开放了！等以后你需要我的帮助时，我一定会答应的 ;p" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Zui), "StartQuests", new() {
            { "Hiya! I think that's all the things I need, you can get some stuff in my shop but thanks babe!", "嗨呀！我觉得我需要的东西已经够用了.谢谢你的好意，看看我的商店如何？" },
        });

        // 主要用于商店注册, 如果同时启用 Shop Expand 能在查询商店时看到汉化效果
        Dictionary<string, string> zuiQuestSystemConditionLocalizations = new() {
            { "ThreeQuests", "需要完成三个任务" },
            { "SixQuests", "需要完成六个任务" },
            { "TenQuests", "需要完成十个任务" },
            { "TwentyQuests", "需要完成二十个任务" },
            { "ThirtyQuests", "需要完成三十个任务" },
        };
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition3", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition6", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition10", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition20", zuiQuestSystemConditionLocalizations);
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Town.ZuiQuestSystem", "get_ShopCondition30", zuiQuestSystemConditionLocalizations);
        #endregion

        #region ZuiDeath
        ForceLocalizeSystem.LocalizeByType(typeof(ZuiDeath), nameof(ZuiDeath.AI), new() {
            { "I think I have a headache..", "我的头好晕..." },
            { "I'll see you later at my shop! Fun time :)", "干得好！想要找我的话就再来我的商店吧！" },
        });
        #endregion
        #region ZuiTheTraveller
        ForceLocalizeSystem.LocalizeByType(typeof(ZuiTheTraveller), nameof(ZuiTheTraveller.SetBestiary), new() {
            { "Zui, not exactly someone that can be killed but loves to play around I guess? Sirestias is closely accompanied with her", "蕊，绝不是什么等闲之辈，但看样子很喜欢休闲玩乐.希丝忒莉亚与她有不浅的交情." },
            { "Zui the Radiance", "辉光女神 蕊" },
        });
        #endregion
        #region EreshkigalIdle
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetBestiary), new() {
            { "A mystical veil user who took accountability to chain up Sigfried", "禁锢了齐格飞的神秘人物" },
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.GetChat), new() {
            { "Leave me and my husband alone", "让我和我的丈夫在这里独享二人时光吧" },
            { "You should all be jealous that I'm here.", "你们都应该羡慕我！" },
            { "Welcome welcome! Come here to feast your eyes on us?", "欢迎！欢迎！来一饱眼福吧" },
            { "Oh dear Sigfried how we've met..", "亲爱的齐格飞...我还记得我们相遇的那天..." },
            { "Come and go you will, you'll be broken more than the others.", "匆忙的来，匆忙的走，将自己搞得支离破碎..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetNPCNameList), new() {
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetChatButtons), new() {
            { "Give her something.", "给她送一件礼物" },
            { "Sigfried?", "询问关于齐格飞" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.OnChatButtonClicked), new() {
            { "OMG, OMG OMG OMG OMG", "天哪天哪天哪天哪！！" },
            { "What is this? Nothing of importance to me... You are worthless, you're life is as valuable as a cinderspark summer ant, you mean nothing. You should get me something good NOW. You should burn in the Cinderspark..", "这是什么...不要紧，它和你一样毫无用处，像一只蚂蚁一样不值一提.赶紧给我找到点有价值的东西，不然我就把你扔到烬火之地永世焚烧." },
            { "Oh what a darling he is. Too bad I'm tasked with keeping him here forever right? He can't escape me :3 ", "我的任务就是把他永远关在这里，对他来说可不是什么好消息对吧 :3" },
            { "Sigfried is my husband you know. We met on the sacred lands of the Illuria, I may have been kicked out numerous times to talk to my king but I'd do anything to get with him", "我丈夫就是齐格飞.我们初次见面是在星树的圣地，我已经被他的守卫赶出那里不知道多少次了，但为了他这一切都值得." },
            { "He's so pure, going for such high level threats such as Lumi and stealing her singularity. That's the type of man I like, one who isn't afraid to get their hands dirty.", "他是那么的纯粹，敢向琉明那样的高级威胁下手，还偷走了她的奇点！我就喜欢这种干事干净利落毫无顾忌的男人." },
            { "I wish we could stay together always.", "我们要永远在一起~" },
            { "Oh his dear Mordred, I bet he doesn't even know hit wife was trapped within a weapon :)", "哦，那个莫德雷德呀...我敢肯定他都不知道他的妻子已经被囚禁在一把武器里了." },
            { "Stupid dragon always getting in the way to getting to my wonderous babe, I would trap it as well but then it'd anger my dearest here.", "那条蠢龙，总是守着我的宝贝不让我靠近...要不是我丈夫会生气，我早就把那龙也关到这里了." },
            { "How many doors do I need to store Lumi? I don't really know but I don't care. As long as she doesn't come after my husband.", "我要用多少扇门才能困住琉明？算了，也不重要，只要她不来找我的丈夫就行." },
        });
        #endregion
    }
}
