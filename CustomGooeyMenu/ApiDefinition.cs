using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CustomGooeyMenu
{
	// @interface Cross : UIView
	[BaseType(typeof(UIView))]
	interface Cross
	{
	}

	// @protocol menuDidSelectedDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface menuDidSelectedDelegate
	{
		// @required -(void)menuDidSelected:(int)index;
		[Abstract]
		[Export("menuDidSelected:")]
		void MenuDidSelected(int index);
	}

	// @interface KYGooeyMenu : UIView
	[BaseType(typeof(UIView))]
	interface KYGooeyMenu
	{
		// @property (assign, nonatomic) int MenuCount;
		[Export("MenuCount")]
		int MenuCount { get; set; }

		// @property (assign, nonatomic) CGFloat radius;
		[Export("radius")]
		nfloat Radius { get; set; }

		// @property (assign, nonatomic) CGFloat extraDistance;
		[Export("extraDistance")]
		nfloat ExtraDistance { get; set; }

		// @property (nonatomic, strong) UIView * mainView;
		[Export("mainView", ArgumentSemantic.Strong)]
		UIView MainView { get; set; }

		// @property (nonatomic, strong) NSMutableArray * menuImagesArray;
		[Export("menuImagesArray", ArgumentSemantic.Strong)]
		NSMutableArray MenuImagesArray { get; set; }

		// -(id)initWithOrigin:(CGPoint)origin andDiameter:(CGFloat)diameter andSuperView:(UIView *)superView themeColor:(UIColor *)themeColor;
		[Export("initWithOrigin:andDiameter:andSuperView:themeColor:")]
		IntPtr Constructor(CGPoint origin, nfloat diameter, UIView superView, UIColor themeColor);

		[Wrap("WeakMenuDelegate")]
		menuDidSelectedDelegate MenuDelegate { get; set; }

		// @property (nonatomic, weak) id<menuDidSelectedDelegate> menuDelegate;
		[NullAllowed, Export("menuDelegate", ArgumentSemantic.Weak)]
		NSObject WeakMenuDelegate { get; set; }
	}

	// @interface KYSpringLayerAnimation : NSObject
	[BaseType(typeof(NSObject))]
	interface KYSpringLayerAnimation
	{
		// +(instancetype)sharedAnimManager;
		[Static]
		[Export("sharedAnimManager")]
		KYSpringLayerAnimation SharedAnimManager();

		// -(CAKeyframeAnimation *)createBasicAnima:(NSString *)keypath duration:(CFTimeInterval)duration fromValue:(id)fromValue toValue:(id)toValue;
		[Export("createBasicAnima:duration:fromValue:toValue:")]
		CAKeyFrameAnimation CreateBasicAnima(string keypath, double duration, NSObject fromValue, NSObject toValue);

		// -(CAKeyframeAnimation *)createSpringAnima:(NSString *)keypath duration:(CFTimeInterval)duration usingSpringWithDamping:(CGFloat)damping initialSpringVelocity:(CGFloat)velocity fromValue:(id)fromValue toValue:(id)toValue;
		[Export("createSpringAnima:duration:usingSpringWithDamping:initialSpringVelocity:fromValue:toValue:")]
		CAKeyFrameAnimation CreateSpringAnima(string keypath, double duration, nfloat damping, nfloat velocity, NSObject fromValue, NSObject toValue);

		// -(CAKeyframeAnimation *)createCurveAnima:(NSString *)keypath duration:(CFTimeInterval)duration fromValue:(id)fromValue toValue:(id)toValue;
		[Export("createCurveAnima:duration:fromValue:toValue:")]
		CAKeyFrameAnimation CreateCurveAnima(string keypath, double duration, NSObject fromValue, NSObject toValue);

		// -(CAKeyframeAnimation *)createHalfCurveAnima:(NSString *)keypath duration:(CFTimeInterval)duration fromValue:(id)fromValue toValue:(id)toValue;
		[Export("createHalfCurveAnima:duration:fromValue:toValue:")]
		CAKeyFrameAnimation CreateHalfCurveAnima(string keypath, double duration, NSObject fromValue, NSObject toValue);
	}

	// @interface MenuLayer : CALayer
	[BaseType(typeof(CALayer))]
	interface MenuLayer
	{
		// @property (assign, nonatomic) BOOL showDebug;
		[Export("showDebug")]
		bool ShowDebug { get; set; }

		// @property (assign, nonatomic) STATE animState;
		[Export("animState", ArgumentSemantic.Assign)]
		State AnimState { get; set; }

		// @property (assign, nonatomic) CGFloat xAxisPercent;
		[Export("xAxisPercent")]
		nfloat XAxisPercent { get; set; }
	}

	// @interface Menu : UIView
	[BaseType(typeof(UIView))]
	interface Menu
	{
		// @property (readonly, nonatomic, strong) MenuLayer * menuLayer;
		[Export("menuLayer", ArgumentSemantic.Strong)]
		MenuLayer MenuLayer { get; }
	}
}
